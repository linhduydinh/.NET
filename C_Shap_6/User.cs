using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Shap_6
{
    public class User
    {
        // backing fields
        //private readonly Guid _id = Guid.NewGuid();
        //public Guid Id
        //{
        //    get { return _id; }
        //}

        //private string _username = String.Empty;
        //public string UserName
        //{
        //    get { return _username; }
        //    protected set { _username = value; }
        //}

        // property
        //public User()
        //{
        //    Id = Guid.NewGuid();
        //}
        //public Guid Id { get; protected set; }
        //public string UserName { get; set; }

        // Auto-property initializers
        public Guid Id { get; protected set; } = Guid.NewGuid();
        public string UserName { get; set; } = String.Empty;
    }
}
