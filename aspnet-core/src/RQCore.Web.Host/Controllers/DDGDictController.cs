using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

using Abp.Domain.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using RQCore.Controllers;
using RQCore.RQDtos;
using RQCore.RQEnitity;
using RQCore.Authorization.Roles;
using RQCore.Authorization.Users;
using Microsoft.AspNetCore.Identity;
using RQCore.Users;
using RQCore.Users.Dto;
using Abp.Authorization.Users;
using RQCore.MultiTenancy; 
using Abp.Authorization; 
using Abp.MultiTenancy;
using Abp.Runtime.Security; 
using RQCore.Authentication.External;
using RQCore.Authentication.JwtBearer;
using RQCore.Authorization;
using RQCore.Models.TokenAuth;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using Abp.Collections.Extensions;
using RQCore.Roles.Dto;
using Abp.Application.Services.Dto;
using RQCore.Sessions.Dto;

namespace RQCore.Web.Host.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    public class DDGDictController : RQCoreControllerBase
    {

        private readonly RoleManager _roleManager;
        private readonly UserManager _userManager;
        private readonly IRepository<Role> _roleRepository;
        private readonly IPasswordHasher<User> _passwordHasher;

        private readonly LogInManager _logInManager;
        private readonly ITenantCache _tenantCache;
        private readonly AbpLoginResultTypeHelper _abpLoginResultTypeHelper;
        private readonly TokenAuthConfiguration _configuration;
        private readonly IExternalAuthConfiguration _externalAuthConfiguration;
        private readonly IExternalAuthManager _externalAuthManager;
        private readonly UserRegistrationManager _userRegistrationManager;






        public DDGDictController(

                IRepository<User, long> repository,
            UserManager userManager,
            RoleManager roleManager,
            IRepository<Role> roleRepository,
            IPasswordHasher<User> passwordHasher,

        
            LogInManager logInManager,
            ITenantCache tenantCache,
            AbpLoginResultTypeHelper abpLoginResultTypeHelper,
            TokenAuthConfiguration configuration,
            IExternalAuthConfiguration externalAuthConfiguration,
            IExternalAuthManager externalAuthManager,
            UserRegistrationManager userRegistrationManager)
        //: base(repository)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _roleRepository = roleRepository;
            _passwordHasher = passwordHasher;


            _logInManager = logInManager;
            _tenantCache = tenantCache;
            _abpLoginResultTypeHelper = abpLoginResultTypeHelper;
            _configuration = configuration;
            _externalAuthConfiguration = externalAuthConfiguration;
            _externalAuthManager = externalAuthManager;
            _userRegistrationManager = userRegistrationManager;
        }
        [HttpPost("api/CreateUser")]
        public async Task<JsonResult> Create(CreateUserDto input)
        {
            //CheckCreatePermission();

            var user = ObjectMapper.Map<User>(input);

            user.TenantId = AbpSession.TenantId;
            user.IsEmailConfirmed = true;

            await _userManager.InitializeOptionsAsync(AbpSession.TenantId);

            CheckErrors(await _userManager.CreateAsync(user, input.Password));

            if (input.RoleNames != null)
            {
                CheckErrors(await _userManager.SetRoles(user, input.RoleNames));
            }

            CurrentUnitOfWork.SaveChanges();

            return Json(Mapper.Map<UserDto>(user));
        }



        [HttpPost("api/AuthenticateTest")]
        public async Task<JsonResult> All()
        {//AuthenticateResultModel
            SortedDictionary<string, object> DgDict= new SortedDictionary<string, object>();
            //IList<object> DgDict = new List<object>();
            var allPermissions = PermissionManager.GetAllPermissions(); 
            DgDict.Add("allPermissions",new ListResultDto<PermissionDto>(
                ObjectMapper.Map<List<PermissionDto>>(allPermissions)
            ));

            var allRoles = await _roleRepository.GetAllListAsync(); 
            DgDict.Add("allRoles", new ListResultDto<RoleListDto>(ObjectMapper.Map<List<RoleListDto>>(allRoles)));

            //new ListResultDto<RoleListDto>(ObjectMapper.Map<List<RoleListDto>>(allRoles));

            return Json(DgDict);
        }



        [HttpPost("api/Authenticate")]
        public async Task<JsonResult> Authenticate([FromBody] AuthenticateModel model)
        {//AuthenticateResultModel
            //IList<object> DgDict = new List<object>();

            var loginResult = await GetLoginResultAsync(
                model.UserNameOrEmailAddress,
                model.Password,
                GetTenancyNameOrNull()
            );





            SortedDictionary<string, object> DgDict = new SortedDictionary<string, object>();
            ////用户信息
            //UserAppService userAppService = new UserAppService();
            //var user = await userAppService.GetEntityByIdAsync( loginResult.User.Id)
            //.FirstOrDefaultAsync(x => x.Id == loginResult.User.Id);

            var user = await _userManager.GetUserByIdAsync(loginResult.User.Id);
            //DgDict.Add(loginResult.User.EmailAddress);
            //ObjectMapper.Map<User>(user);
            //      {
            //var user = await Repository.GetAllIncluding(x => x.Roles).FirstOrDefaultAsync(x => x.Id == id);
// trafficLog
// 括0在途中、1已揽收、2疑难、3已签收、4退签、5同城派送中、6退回、7转单等7个状态，其中4-7需要另外开通才有效
//  StatuesNo  displayName   description  

struct trafficLogDict
{
//    public string Status ;
   
   public int  StatueNo ;
   public string displayName;
   public string description;
}; 
            DgDict.Add("CurrentLogin", Mapper.Map<CreateUserDto>(user)
          //ObjectMapper.Map<UserDto> (loginResult.User)
          );

// InspectionState	int	default 0	审批状态,0-已申请,1-通过,2-驳回




           DgDict.Add("trafficLogDict",);
            
            //IList<object> DgDict = new List<object>();
            var allPermissions = PermissionManager.GetAllPermissions();
            DgDict.Add("allPermissions", new ListResultDto<PermissionDto>(
                ObjectMapper.Map<List<PermissionDto>>(allPermissions)
            ));

            var allRoles = await _roleRepository.GetAllListAsync();
            DgDict.Add("allRoles", new ListResultDto<RoleListDto>(ObjectMapper.Map<List<RoleListDto>>(allRoles)));

            //new ListResultDto<RoleListDto>(ObjectMapper.Map<List<RoleListDto>>(allRoles));

            //ICollection<UserRole> roles = loginResult.User.Roles;
            ////ICollection<UserRole> roles = user.Roles;
            //DgDict.Add(roles);

            //var allPermissions = PermissionManager.GetAllPermissions();

            //DgDict.Add(allPermissions);
            //var allRoles = await _roleRepository.GetAllListAsync();

            //DgDict.Add(allRoles);
            //.Roles
            //.WhereIf(
            //    !input.Permission.IsNullOrWhiteSpace(),
            //    r => r.Permissions.Any(rp => rp.Name == input.Permission && rp.IsGranted)
            //)
            //.ToListAsync();

            //return new ListResultDto<RoleListDto>(ObjectMapper.Map<List<RoleListDto>>(roles));

            var accessToken = CreateAccessToken(CreateJwtClaims(loginResult.Identity));
            DgDict.Add("AuthenticateResultModel",
                   new AuthenticateResultModel
                   {
                       AccessToken = accessToken,
                       EncryptedAccessToken = GetEncrpyedAccessToken(accessToken),
                       ExpireInSeconds = (int)_configuration.Expiration.TotalSeconds,
                       UserId = loginResult.User.Id
                   }
                );

      


            return Json(DgDict);
        }


        private static List<Claim> CreateJwtClaims(ClaimsIdentity identity)
        {
            var claims = identity.Claims.ToList();
            var nameIdClaim = claims.First(c => c.Type == ClaimTypes.NameIdentifier);

            // Specifically add the jti (random nonce), iat (issued timestamp), and sub (subject/user) claims.
            claims.AddRange(new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, nameIdClaim.Value),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Iat, DateTimeOffset.Now.ToUnixTimeSeconds().ToString(), ClaimValueTypes.Integer64)
            });

            return claims;
        }

        private string GetEncrpyedAccessToken(string accessToken)
        {
            return SimpleStringCipher.Instance.Encrypt(accessToken, AppConsts.DefaultPassPhrase);
        }


        private async Task<AbpLoginResult<Tenant, User>> GetLoginResultAsync(string usernameOrEmailAddress, string password, string tenancyName)
        {
            var loginResult = await _logInManager.LoginAsync(usernameOrEmailAddress, password, tenancyName);

            switch (loginResult.Result)
            {
                case AbpLoginResultType.Success:
                    return loginResult;
                default:
                    throw _abpLoginResultTypeHelper.CreateExceptionForFailedLoginAttempt(loginResult.Result, usernameOrEmailAddress, tenancyName);
            }
        }




        private string CreateAccessToken(IEnumerable<Claim> claims, TimeSpan? expiration = null)
        {
            var now = DateTime.UtcNow;

            var jwtSecurityToken = new JwtSecurityToken(
                issuer: _configuration.Issuer,
                audience: _configuration.Audience,
                claims: claims,
                notBefore: now,
                expires: now.Add(expiration ?? _configuration.Expiration),
                signingCredentials: _configuration.SigningCredentials
            );

            return new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);
        }








        private string GetTenancyNameOrNull()
        {
            if (!AbpSession.TenantId.HasValue)
            {
                return null;
            }

            return _tenantCache.GetOrNull(AbpSession.TenantId.Value)?.TenancyName;
        }


    }
}