using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using HealthyAndHappy.Models.ModelsDTO;
using HealthyAndHappy.Models;

namespace HealthyAndHappy.Extensions.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ApplicationUser, UserDTO>().
                ForMember(vm => vm.Id, map => map.MapFrom(m => m.Id)).
                ForMember(vm => vm.Name, map => map.MapFrom(m => m.UserName)).
                ForMember(vm => vm.Mail, map => map.MapFrom(m => m.Email)).
                ForMember(vm => vm.Password, map => map.MapFrom(m => m.PasswordHash)).
                ForMember(vm => vm.Histories, map => map.MapFrom(m => m.Histories)).
                ForMember(vm => vm.Recipes, map => map.MapFrom(m => m.Histories));
            CreateMap<UserDTO,ApplicationUser>().
                ForMember(vm => vm.Id, map => map.MapFrom(m => m.Id)).
                ForMember(vm => vm.UserName, map => map.MapFrom(m => m.Name)).
                ForMember(vm => vm.Email, map => map.MapFrom(m => m.Mail)).
                ForMember(vm => vm.PasswordHash, map => map.MapFrom(m => m.Password)).
                ForMember(vm => vm.Histories, map => map.MapFrom(m => m.Histories)).
                ForMember(vm => vm.Recipes, map => map.MapFrom(m => m.Histories));

            CreateMap<History, HistoryDTO>().
                ForMember(vm => vm.Id, map => map.MapFrom(m => m.Id)).
                ForMember(vm => vm.Kcal, map => map.MapFrom(m => m.Id)).
                ForMember(vm => vm.Recipe, map => map.MapFrom(m => m.Recipe)).
                ForMember(vm => vm.Date, map => map.MapFrom(m => m.Date));
            CreateMap<HistoryDTO, History>().
                ForMember(vm => vm.Id, map => map.MapFrom(m => m.Id)).
                ForMember(vm => vm.Kcal, map => map.MapFrom(m => m.Id)).
                ForMember(vm => vm.Recipe, map => map.MapFrom(m => m.Recipe)).
                ForMember(vm => vm.Date, map => map.MapFrom(m => m.Date));

            CreateMap<Larder, LarderDTO>().
                ForMember(vm => vm.Id, map => map.MapFrom(m => m.Id)).
                ForMember(vm => vm.Meats, map => map.MapFrom(m => m.Meats)).
                ForMember(vm => vm.Nuts, map => map.MapFrom(m => m.Nuts)).
                ForMember(vm => vm.Sauces, map => map.MapFrom(m => m.Sauces)).
                ForMember(vm => vm.Specials, map => map.MapFrom(m => m.Specials)).
                ForMember(vm => vm.Spices, map => map.MapFrom(m => m.Spices)).
                ForMember(vm => vm.Vegetables, map => map.MapFrom(m => m.Vegetables)).
                ForMember(vm => vm.Alcohols, map => map.MapFrom(m => m.Alcohols)).
                ForMember(vm => vm.Carbohydrates, map => map.MapFrom(m => m.Carbohydrates)).
                ForMember(vm => vm.Diaries, map => map.MapFrom(m => m.Diaries)).
                ForMember(vm => vm.Drinks, map => map.MapFrom(m => m.Drinks)).
                ForMember(vm => vm.DryGoods, map => map.MapFrom(m => m.DryGoods)).
                ForMember(vm => vm.Fats, map => map.MapFrom(m => m.Fats)).
                ForMember(vm => vm.FishAndSeafoods, map => map.MapFrom(m => m.FishAndSeafoods)).
                ForMember(vm => vm.Fruits, map => map.MapFrom(m => m.Fruits));
            CreateMap<LarderDTO,Larder>().
                ForMember(vm => vm.Id, map => map.MapFrom(m => m.Id)).
                ForMember(vm => vm.Meats, map => map.MapFrom(m => m.Meats)).
                ForMember(vm => vm.Nuts, map => map.MapFrom(m => m.Nuts)).
                ForMember(vm => vm.Sauces, map => map.MapFrom(m => m.Sauces)).
                ForMember(vm => vm.Specials, map => map.MapFrom(m => m.Specials)).
                ForMember(vm => vm.Spices, map => map.MapFrom(m => m.Spices)).
                ForMember(vm => vm.Vegetables, map => map.MapFrom(m => m.Vegetables)).
                ForMember(vm => vm.Alcohols, map => map.MapFrom(m => m.Alcohols)).
                ForMember(vm => vm.Carbohydrates, map => map.MapFrom(m => m.Carbohydrates)).
                ForMember(vm => vm.Diaries, map => map.MapFrom(m => m.Diaries)).
                ForMember(vm => vm.Drinks, map => map.MapFrom(m => m.Drinks)).
                ForMember(vm => vm.DryGoods, map => map.MapFrom(m => m.DryGoods)).
                ForMember(vm => vm.Fats, map => map.MapFrom(m => m.Fats)).
                ForMember(vm => vm.FishAndSeafoods, map => map.MapFrom(m => m.FishAndSeafoods)).
                ForMember(vm => vm.Fruits, map => map.MapFrom(m => m.Fruits));

            CreateMap<Message, MessageDTO>().
                ForMember(vm => vm.Id, map => map.MapFrom(m => m.Id)).
                ForMember(vm => vm.SenderId, map => map.MapFrom(m => m.Sender)).
                ForMember(vm => vm.Text, map => map.MapFrom(m => m.Text)).
                ForMember(vm => vm.Date, map => map.MapFrom(m => m.Date));
            CreateMap<MessageDTO,Message>().
                ForMember(vm => vm.Id, map => map.MapFrom(m => m.Id)).
                ForMember(vm => vm.Sender, map => map.MapFrom(m => m.SenderId)).
                ForMember(vm => vm.Text, map => map.MapFrom(m => m.Text)).
                ForMember(vm => vm.Date, map => map.MapFrom(m => m.Date));


        }
    }
}
