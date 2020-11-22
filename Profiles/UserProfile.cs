using AutoMapper;
using Messenger.Areas.Identity.Pages.Account;
using Messenger.Models.Entities;
using Messenger.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Messenger.Profiles
{
    public class UserProfile:Profile
    {
        public UserProfile()
        {
            CreateMap<RegisterViewModel, User>();
            CreateMap<User, UserViewModel>()
                .ForMember(dest => dest.Username, source => source.MapFrom(source => source.Firstname + source.Secondname ));
        }
    }
}
