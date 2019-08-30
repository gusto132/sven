using System;
using System.Linq;
using System.Web;
using System.Collections.Generic;
using System.Text;
using sven.models.access;
using sven.business.middleware;
using sven.models;
using sven.models.view;

namespace sven.business.models
{
    public class AuthBusiness : BaseBusiness
    {
        public SvenDbContext _context;

        public AuthenticationMiddleware _authentication;

        public AuthBusiness(SvenDbContext context)
        {
            _context = context;      
        }

        public void Validate(string authenticationCookie)
        { 
                if (UserExists(authenticationCookie))
                {
                    var auth = new AuthenticationMiddleware();

                    var user = _context.Users.FirstOrDefault(u => u.Login == authenticationCookie);

                    Model = new AuthView();

                    ((AuthView)Model).Token = auth.GenerateToken(user);
                }

                else ((AuthView)Model).Token = null;
        }

        private bool UserExists(string authenticationCookie)
        {
            return _context.Users.Any(u => u.Login == authenticationCookie);
        }
    }
}