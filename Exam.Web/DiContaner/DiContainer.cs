

using Exam.IRepository.Email;
using Exam.Repository.Email;

using Exam.Irepository.ISport;
using Exam.Repository.PatientRepo;
using FstMonthExam.IRepository.Factory;
using FstMonthExam.Repository.Factory;


using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace Exam.Web.DiContaner
{
    public static class DiContainer
    {
        public static void AddCustomContainer(this IServiceCollection services, IConfiguration configuration)
        {
            IConnectionFactory connectionFactory = new ConnectionFactory(configuration.GetConnectionString("DefaultConnection"));
            services.AddSingleton(connectionFactory);
            services.AddScoped<SpotInterface, PatientRepositary>();
            services.AddScoped<IMailService, MailService>();



        }
    }
}
