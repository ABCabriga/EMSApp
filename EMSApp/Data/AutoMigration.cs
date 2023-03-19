//namespace EMSApp.Data
//{
//    public static class AutoMigration
//    {


//        public static void Automigrate(this WebApplication application)
//        {
//            using (var scope = application.Services.CreateScope())
//            {

//                using (var appContext = scope.ServiceProvider.GetRequiredService<EmployeesDBContext>())
//                {

//                    try
//                    {
//                        appContext.Database.Migrate();
//                    }
//                    catch (Exception ex)
//                    {

//                        throw;
//                    }
//                }
//            }
//        }


//    }

//}
