﻿using System;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Principal;
using Angkor.O7Framework.ServiceClient.SecurityClient;

namespace Angkor.O7Framework.Web
{
    public class O7User : IPrincipal
    {
        public O7User (string nickName, string password, string name, Company company, Branch branch)
        {
            Contract.Requires<ArgumentNullException> (string.IsNullOrEmpty (nickName));
            Contract.Requires<ArgumentNullException> (string.IsNullOrEmpty (password));
            Contract.Requires<ArgumentNullException> (company?.Branches != null && company.Branches.All (item => !string.IsNullOrEmpty (item?.Id)));
            CurrentIdentity = new O7Identity (name, branch);
            NickName = nickName;
            Password = password;
            Company = company;
        }

        public string NickName { get; }

        public string Password { get; }

        public O7Identity CurrentIdentity { get; }

        public Company Company { get; }        

        #region Implementation of IPrincipal
        /// <summary>Determines whether the current principal belongs to the specified role.</summary>
        /// <returns>true if the current principal is a member of the specified role; otherwise, false.</returns>
        /// <param name="role">The name of the role for which to check membership. </param>
        public bool IsInRole (string role) => true;

        /// <summary>Gets the identity of the current principal.</summary>
        /// <returns>The <see cref="T:System.Security.Principal.IIdentity" /> object associated with the current principal.</returns>
        public IIdentity Identity => CurrentIdentity;
        #endregion
    }
}