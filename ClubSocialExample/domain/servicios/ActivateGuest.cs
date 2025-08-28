using ClubSocialExample.domain.model;
using ClubSocialExample.domain.ports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubSocialExample.domain.servicios
{
    class ActivateGuest
    {
        private GuestPort guestPort;
        private PartnerPort partnerPort;
        
        public void Activate(Guest guest)
        {
            guest = guestPort.FindByDocument(guest);
            if(guest == null)
            {
                throw new Exception("El invitado no existe");
            }

            if(guest.Partner.Type.Equals("regular") && partnerPort.CountActiveGuest(guest.Partner) >= 3)
            {
                throw new Exception("Los socios regulares solo pueden tener 3 invitados activos");
            }

            guest.Status = true;
            guestPort.Update(guest);
        }
    }
}
