using System;
using Autofac;
using WinFormsApp1.Forms;
using WinFormsApp1.Repositories.Interfaces;
using WinFormsApp1.Repositories.Stubs;

namespace WinFormsApp1.Infrastructure
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            // 1. Репозитории (заглушки)
            builder.RegisterType<FacultyRepositoryStub>().As<IFacultyRepository>().SingleInstance();
            builder.RegisterType<DisciplineRepositoryStub>().As<IDisciplineRepository>().SingleInstance();
            builder.RegisterType<StudentGroupRepositoryStub>().As<IStudentGroupRepository>().SingleInstance();


            builder.RegisterType<StudentRepositoryStub>().As<IStudentRepository>().SingleInstance();
            builder.RegisterType<StudentListForm>().AsSelf();
            builder.RegisterType<StudentEditForm>().AsSelf();

            builder.RegisterType<ExamResultRepositoryStub>().As<IExamResultRepository>().SingleInstance();
            builder.RegisterType<ExamResultListForm>().AsSelf();
            builder.RegisterType<ExamResultEditForm>().AsSelf();

            // 2. Формы
            builder.RegisterType<MainForm>().AsSelf();
            builder.RegisterType<FacultyListForm>().AsSelf();
            builder.RegisterType<FacultyEditForm>().AsSelf();
            builder.RegisterType<DisciplineListForm>().AsSelf();
            builder.RegisterType<DisciplineEditForm>().AsSelf();
            builder.RegisterType<GroupListForm>().AsSelf();
            builder.RegisterType<GroupEditForm>().AsSelf();

            return builder.Build();
        }
    }
}