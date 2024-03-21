using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using MVCRemote.Common;

namespace MVCRemote.Models
{
    [MetadataType(typeof(UserMetadata))]
    public partial class User
    {
    }
    public class UserMetadata
    {
        [RemoteClientServer("IsUserNameAvailable1", "Home", ErrorMessage = "UserName already in use")]
        public string UserName { get; set; }
    }
}