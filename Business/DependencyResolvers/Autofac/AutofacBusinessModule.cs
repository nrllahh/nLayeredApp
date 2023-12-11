using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance(); 
            //IProductService isteyen yere ProductManager instance'i ver.
            //builder.Services.AddSingleton<IProductService, ProductManager>(); yerine bunu kullanıyoruz. aynı şey
            builder.RegisterType<EfProductDal>().As<IProductDal>().SingleInstance();
        }
    }
}
