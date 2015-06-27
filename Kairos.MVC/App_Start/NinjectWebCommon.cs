using Kairos.Application;
using Kairos.Application.Interfaces;
using Kairos.Domain.Interfaces.Repositories;
using Kairos.Domain.Interfaces.Services;
using Kairos.Domain.Services;
using Kairos.Infra.Data.Repositories;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(Kairos.MVC.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(Kairos.MVC.App_Start.NinjectWebCommon), "Stop")]

namespace Kairos.MVC.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {

            kernel.Bind(typeof(IBaseApplicationService<>)).To(typeof(BaseApplicationService<>));
            kernel.Bind<ICommentApplicationService>().To<CommentApplicationService>();
            kernel.Bind<IIssueApplicationService>().To<IssueApplicationService>();
            kernel.Bind<IMeasureApplicationService>().To<MeasureApplicationService>();
            kernel.Bind<IPriorityApplicationService>().To<PriorityApplicationService>();
            kernel.Bind<IRankingApplicationService>().To<RankingApplicationService>();
            kernel.Bind<ISprintApplicationService>().To<SprintApplicationService>();
            kernel.Bind<IStatusApplicationService>().To<StatusApplicationService>();
            kernel.Bind<ITeamApplicationService>().To<TeamApplicationService>();
            kernel.Bind<ITicketApplicationService>().To<TicketApplicationService>();
            kernel.Bind<ITimesheetApplicationService>().To<TimesheetApplicationService>();

            kernel.Bind(typeof(IBaseService<>)).To(typeof(BaseService<>));
            kernel.Bind<ICommentService>().To<CommentService>();
            kernel.Bind<IIssueService>().To<IssueService>();
            kernel.Bind<IMeasureService>().To<MeasureService>();
            kernel.Bind<IPriorityService>().To<PriorityService>();
            kernel.Bind<IRankingService>().To<RankingService>();
            kernel.Bind<ISprintService>().To<SprintService>();
            kernel.Bind<IStatusService>().To<StatusService>();
            kernel.Bind<ITeamService>().To<TeamService>();
            kernel.Bind<ITicketService>().To<TicketService>();
            kernel.Bind<ITimesheetService>().To<TimesheetService>();

            kernel.Bind(typeof(IBaseRepository<>)).To(typeof(BaseRepository<>));
            kernel.Bind<ICommentRepository>().To<CommentRepository>();
            kernel.Bind<IIssueRepository>().To<IssueRepository>();
            kernel.Bind<IMeasureRepository>().To<MeasureRepository>();
            kernel.Bind<IPriorityRepository>().To<PriorityRepository>();
            kernel.Bind<IRankingRepository>().To<RankingRepository>();
            kernel.Bind<ISprintRepository>().To<SprintRepository>();
            kernel.Bind<IStatusRepository>().To<StatusRepository>();
            kernel.Bind<ITeamRepository>().To<TeamRepository>();
            kernel.Bind<ITicketRepository>().To<TicketRepository>();
            kernel.Bind<ITimesheetRepository>().To<TimesheetRepository>();

        }        
    }
}
