using System.Web;
using Autofac;
using Codesanook.Common.Web;
using JavaScriptEngineSwitcher.Core;
using JavaScriptEngineSwitcher.V8;
using React;

namespace Codesanook.Common {
    public class ComponentModule : Module {

        protected override void Load(ContainerBuilder builder) {

            JsEngineSwitcher.Current.DefaultEngineName = V8JsEngine.EngineName;
            JsEngineSwitcher.Current.EngineFactories.AddV8();

            builder.RegisterInstance(JsEngineSwitcher.Current).As<IJsEngineSwitcher>().SingleInstance();
            builder.RegisterInstance(ReactSiteConfiguration.Configuration).As<IReactSiteConfiguration>().SingleInstance();
            builder.Register(c => new AspNetCache(HttpRuntime.Cache)).As<ICache>().InstancePerDependency();
            builder.RegisterType<AspNetFileSystem>().As<IFileSystem>().InstancePerDependency();
            builder.RegisterType<JavaScriptEngineFactory>().As<IJavaScriptEngineFactory>().SingleInstance();

            builder.RegisterType<FileCacheHash>().As<IFileCacheHash>().InstancePerDependency();
            builder.RegisterType<JavaScriptEngineFactory>().As<JavaScriptEngineFactory>().SingleInstance();
            builder.RegisterType<ReactIdGenerator>().As<IReactIdGenerator>().SingleInstance();
            builder.RegisterType<ReactEnvironment>().As<IReactEnvironment>().InstancePerLifetimeScope();
        }
    }
}