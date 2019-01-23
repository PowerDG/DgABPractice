var dbExistEntities = _testSizeValueValueRepository
      .GetAllIncluding (
            os => os.TestSizeInfo,
            os => os.TestSizeInfo.TestSizeHead, 
            os => os.StandardSizeValue)
      .Where (os =>
            os.TestSizeInfo.TestSizeHead.Id == rawData.TestSizeHead.Id &&
            os.IsAim == firstEntity.IsAim
      ).ToList ();



// VsCode 插件整理之C#  FixFormat
// https://blog.csdn.net/u011127019/article/details/75503382

过程式

 using (var unitOfWork = _unitOfWorkManager.Begin())
                {
                   。。。
                    unitOfWork.Complete();
                }

过程式,  只要能Resolve UnitOfWorkManager, 就能Run

声明式

[UnitOfWork]
        public void SomeMethod( )
        {
           ...
        }

声明式, 这种就不一定能Run了！

声明式的这些限制，其实是由拦截器的实现机制引起的，ABP的拦截器是用Castle DynamicProxy 动态代理来做的，动态代理是在运行时生成（使用.Net emit）一个新类（继承于原类或接口），拦截的method, 都是用override来插入代码的， 所以只能支持Interface或Virtual的方法。

总结：ABP中大量使用了AOP(面向切面编程)，分离了横切关注点：Authorization, Validation, Exception Handling, Logging, Localization, Database Connection Management, Setting Management, Audit Logging；实现机理是用动态代理做的拦截器， 作为开发者对这个机理的彻底了解，有助于我更好的使用框架，也有助于用类似的方法做我们自己的AOP,毕竟AOP是我辈热衷于OOP的开发者必须掌握的技术！