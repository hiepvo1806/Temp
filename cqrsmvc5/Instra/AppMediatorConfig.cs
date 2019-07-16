using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Threading.Tasks;
using MediatR;
using MediatR.Pipeline;
using Unity;
using Unity.Lifetime;
using Unity.Registration;

namespace cqrsmvc5.Instra
{
    public static class AppMediatorConfig
    {
        public static IMediator BuildMediator(IUnityContainer container)
        {
            container
                .RegisterMediator(new HierarchicalLifetimeManager())
                .RegisterMediatorHandlers(Assembly.GetAssembly(typeof(Ping)));

            container.RegisterType(typeof(IPipelineBehavior<,>), typeof(RequestPreProcessorBehavior<,>), "RequestPreProcessorBehavior");
            container.RegisterType(typeof(IPipelineBehavior<,>), typeof(RequestPostProcessorBehavior<,>), "RequestPostProcessorBehavior");
            #region comment

            //container.RegisterType(typeof(IPipelineBehavior<,>), typeof(GenericPipelineBehavior<,>), "GenericPipelineBehavior");
            ////container.RegisterType(typeof(IRequestPreProcessor<>), typeof(GenericRequestPreProcessor<>), "GenericRequestPreProcessor");
            //container.RegisterType(typeof(IRequestPostProcessor<,>), typeof(GenericRequestPostProcessor<,>), "GenericRequestPostProcessor");
            //container.RegisterType(typeof(IRequestPostProcessor<,>), typeof(ConstrainedRequestPostProcessor<,>), "ConstrainedRequestPostProcessor");

            // Unity doesn't support generic constraints
            //container.RegisterType(typeof(INotificationHandler<>), typeof(ConstrainedPingedHandler<>), "ConstrainedPingedHandler");

            #endregion
            return container.Resolve<IMediator>();
        }
    }
   
}
