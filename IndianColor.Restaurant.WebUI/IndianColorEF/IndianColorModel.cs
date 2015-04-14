namespace IndianColor.Restaurant.IndianColorEF
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;

    public class IndianColorModel : DbContext
    {
        // Your context has been configured to use a 'IndianColorModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'IndianColor.Restaurant.IndianColorEF.IndianColorModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'IndianColorModel' 
        // connection string in the application configuration file.
        public IndianColorModel()
            : base("name=IndianColorModel")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<FoodMenuItem> FoodMenuItems { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
    }
}