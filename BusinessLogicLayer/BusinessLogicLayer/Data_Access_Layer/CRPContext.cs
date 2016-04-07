namespace BusinessLogicLayer.Data_Access_Layer
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class CRPContext : DbContext
    {
        public CRPContext()
            : base("name=CRPContext")
        {
        }
        
    }

}