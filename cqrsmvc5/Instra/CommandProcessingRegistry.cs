//using FluentValidation;
//using MediatR;
//using StructureMap.Configuration.DSL;

//namespace cqrsmvc5.Instra
//{
//    public class CommandProcessingRegistry : Registry
//    {
//        public CommandProcessingRegistry()
//        {
//            Scan(aAssemblyScanner =>
//            {
//                aAssemblyScanner.AssemblyContainingType<IMediator>();
//                aAssemblyScanner.AssemblyContainingType<CommandProcessingRegistry>();

//                aAssemblyScanner.AddAllTypesOf(typeof(IRequestHandler<,>));
//                aAssemblyScanner.AddAllTypesOf(typeof(IAsyncRequestHandler<,>));
//                aAssemblyScanner.AddAllTypesOf(typeof(IValidator<>));
//                aAssemblyScanner.WithDefaultConventions();
//            });

//            For<SingleInstanceFactory>().Use<SingleInstanceFactory>(aContext => aType => aContext.GetInstance(aType));
//            For<MultiInstanceFactory>().Use<MultiInstanceFactory>(aContext => aType => aContext.GetAllInstances(aType));
//        }
//    }

//}
