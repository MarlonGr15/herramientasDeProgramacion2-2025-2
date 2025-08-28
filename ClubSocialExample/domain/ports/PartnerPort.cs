using ClubSocialExample.domain.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubSocialExample.domain.ports
{
    interface PartnerPort
    {
        public int CountActiveGuest(Partner partner);
        public Partner FindByDocument(Partner partner);
        public Partner FindByUserName(Partner partner);
        public void Save(Partner partner);
    }
}
