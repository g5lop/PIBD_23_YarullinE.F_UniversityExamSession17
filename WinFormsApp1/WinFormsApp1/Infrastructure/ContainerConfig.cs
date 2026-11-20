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

            builder.RegisterType<FacultyRepositoryStub>().As<IFacultyRepository>().SingleInstance();

            builder.RegisterType<MainForm>().AsSelf();
            builder.RegisterType<FacultyListForm>().AsSelf();
            builder.RegisterType<FacultyEditForm>().AsSelf();

            return builder.Build();
        }
    }
}