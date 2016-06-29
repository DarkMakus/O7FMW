using System;
using System.Diagnostics.Contracts;
using System.Security.Principal;
using Angkor.O7Framework.ServiceClient.SecurityClient;

namespace Angkor.O7Framework.Web
{
    public class O7Identity : IIdentity
    {
        public O7Identity (string name, Branch branch, bool authentication = true)
        {
            Contract.Requires<ArgumentNullException> (!string.IsNullOrEmpty (name));
            Contract.Requires<ArgumentNullException> (branch != null && string.IsNullOrEmpty (branch.Id));
            Name = name;
            Branch = branch;
            IsAuthenticated = authentication;
        }

        public Branch Branch { get; }

        #region Implementation of IIdentity
        /// <summary>Gets the name of the current user.</summary>
        /// <returns>The name of the user on whose behalf the code is running.</returns>
        public string Name { get; }
        /// <summary>Gets the type of authentication used.</summary>
        /// <returns>The type of authentication used to identify the user.</returns>
        public string AuthenticationType => "AKG_AUTH";
        /// <summary>Gets a value that indicates whether the user has been authenticated.</summary>
        /// <returns>true if the user was authenticated; otherwise, false.</returns>
        public bool IsAuthenticated { get; }
        #endregion
    }
}