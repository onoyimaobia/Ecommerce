using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klir.TechChallenge.Web.Domain.Models.DTO
{
    public class IndividualButtonPartial
    {
        public string Page { get; set; }
        public string Controller { get; set; }
        public string FontAwesome { get; set; }
        public string ButtonType { get; set; }
        public long Id { get; set; }

        public long ActionParameter
        {
            get
            {
                if (Id > 0 )
                {
                    return Id;
                }
                return 0;
            }
        }
    }
}
