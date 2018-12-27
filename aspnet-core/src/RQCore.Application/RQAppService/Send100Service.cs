using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Abp.AutoMapper;
using Abp.Linq.Extensions;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RQCore.RQDtos;
using RQCore.RQEnitity;
using Abp.Extensions;
using RQCore.IRQAppService;
using System.Collections;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace RQCore.RQAppService
{
   public class Send100Service : RQCoreAppServiceBase
    {
        public class Program
        {

            private static bool CheckValidationResult(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)

            {
                return true; //总是接受   
            }
            public static  HttpWebResponse CreatePostHttpResponse(string url, IDictionary parameters, Encoding encoding)
            {
                HttpWebRequest request = null;
                //HTTPSQ请求
                ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(CheckValidationResult);
                request = WebRequest.Create(url) as HttpWebRequest;
                request.ProtocolVersion = HttpVersion.Version10;
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                //request.UserAgent = DefaultUserAgent;
                //如果需要POST数据   
                if (!(parameters == null || parameters.Count == 0))
                {
                    StringBuilder buffer = new StringBuilder();
                    int i = 0;
                    foreach (string key in parameters.Keys)
                    {
                        if (i > 0)
                        {
                            buffer.AppendFormat("&{0}={1}", key, parameters[key]);
                        }
                        else
                        {
                            buffer.AppendFormat("{0}={1}", key, parameters[key]);
                        }
                        i++;
                    }
                    byte[] data = System.Text.Encoding.ASCII.GetBytes(buffer.ToString());
                    using (Stream stream = request.GetRequestStream())
                    {
                        stream.Write(data, 0, data.Length);
                    }
                }
                return request.GetResponse() as HttpWebResponse;
            }


        }
        public string Get(string com, string strl)
        {
            string url = "http://poll.kuaidi100.com/poll/query.do";
            Encoding encoding = Encoding.GetEncoding("utf-8");

            //参数
            string str = strl;
            string param = "{\"com\":\""+ com + "\",\"num\":\"" + str + "\",\"from\":\"\",\"to\":\"\"}";
            string customer = "4FC24438857676E915EE243C171CFE5B";
            string key = "xjpUzFiv7191";
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] InBytes = Encoding.GetEncoding("UTF-8").GetBytes(param + key + customer);
            byte[] OutBytes = md5.ComputeHash(InBytes);
            string OutString = "";
            for (int i = 0; i < OutBytes.Length; i++)
            {
                OutString += OutBytes[i].ToString("x2");
            }
            string sign = OutString.ToUpper();
            IDictionary parameters = new Dictionary<string, string>();
            parameters.Add("param", param);
            parameters.Add("customer", customer);
            parameters.Add("sign", sign);
            HttpWebResponse response = Program.CreatePostHttpResponse(url, parameters, encoding);
            //打印返回值
            System.IO.Stream stream = response.GetResponseStream();   //获取响应的字符串流
            StreamReader sr = new StreamReader(stream); //创建一个stream读取流
            string html = sr.ReadToEnd();   //从头读到尾，放到字符串html
            return html;
        }


       
    }
}
