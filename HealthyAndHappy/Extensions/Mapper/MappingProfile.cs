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
                ForMember(vm => vm.Larder, map => map.MapFrom(m => m.Larder)).
                ForMember(vm => vm.Name, map => map.MapFrom(m => m.UserName)).
                ForMember(vm => vm.Mail, map => map.MapFrom(m => m.Email)).
                ForMember(vm => vm.Password, map => map.MapFrom(m => m.PasswordHash)).
                ForMember(vm => vm.Histories, map => map.MapFrom(m => m.Histories)).
                ForMember(vm => vm.Recipes, map => map.MapFrom(m => m.Histories)).
                ForMember(vm => vm.RecipesCreatedByMy, map => map.MapFrom(m => m.RecipesCreatedByMy));
            CreateMap<UserDTO,ApplicationUser>().
                ForMember(vm => vm.Id, map => map.MapFrom(m => m.Id)).
                ForMember(vm=>vm.Larder,map=>map.MapFrom(m=>m.Larder)).
                ForMember(vm => vm.UserName, map => map.MapFrom(m => m.Name)).
                ForMember(vm => vm.Email, map => map.MapFrom(m => m.Mail)).
                ForMember(vm => vm.PasswordHash, map => map.MapFrom(m => m.Password)).
                ForMember(vm => vm.Histories, map => map.MapFrom(m => m.Histories)).
                ForMember(vm => vm.FavouriteRecipes, map => map.MapFrom(m => m.Histories)).
                ForMember(vm => vm.RecipesCreatedByMy, map => map.MapFrom(m => m.RecipesCreatedByMy));

            CreateMap<History, HistoryDTO>().
                ForMember(vm => vm.Id, map => map.MapFrom(m => m.Id)).
                ForMember(vm => vm.Kcal, map => map.MapFrom(m => m.Id)).
                ForMember(vm => vm.Recipe, map => map.MapFrom(m => m.Recipe)).
                ForMember(vm => vm.Date, map => map.MapFrom(m => m.Date)).
                ForMember(vm=>vm.UserId, map=>map.MapFrom(m=>m.UserId));

            CreateMap<HistoryDTO, History>().
                ForMember(vm => vm.Id, map => map.MapFrom(m => m.Id)).
                ForMember(vm => vm.Kcal, map => map.MapFrom(m => m.Id)).
                ForMember(vm => vm.Recipe, map => map.MapFrom(m => m.Recipe)).
                ForMember(vm => vm.Date, map => map.MapFrom(m => m.Date)).
                ForMember(vm => vm.UserId, map => map.MapFrom(m => m.UserId));

            CreateMap<Larder, LarderDTO>().
                ForMember(vm => vm.Id, map => map.MapFrom(m => m.Id)).
                ForMember(vm => vm.User, map => map.MapFrom(m => m.User)).
                ForMember(vm => vm.Products, map => map.MapFrom(m => m.Products));
              
            CreateMap<LarderDTO,Larder>().
                ForMember(vm => vm.Id, map => map.MapFrom(m => m.Id)).
                ForMember(vm=>vm.User,map =>map.MapFrom(m=>m.User)).
                ForMember(vm => vm.Products, map => map.MapFrom(m => m.Products));

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

            CreateMap<Recipe, RecipeDTO>().
                ForMember(vm => vm.Id, map => map.MapFrom(m => m.Id)).
                ForMember(vm => vm.IdUser, map => map.MapFrom(m => m.Maker.Id)).
                ForMember(vm => vm.IsAccepted, map => map.MapFrom(m => m.IsAccepted)).
                ForMember(vm => vm.Kcal, map => map.MapFrom(m => m.Kcal)).
                ForMember(vm => vm.Carbohydrates, map => map.MapFrom(m => m.Carbohydrates)).
                ForMember(vm => vm.Fat, map => map.MapFrom(m => m.Fat)).
                ForMember(vm => vm.Proteins, map => map.MapFrom(m => m.Proteins)).
                ForMember(vm => vm.Name, map => map.MapFrom(m => m.Name)).
                ForMember(vm => vm.PreprationTime, map => map.MapFrom(m => m.PreprationTime)).
                ForMember(vm => vm.Category, map => map.MapFrom(m => m.Category)).
                ForMember(vm => vm.Description, map => map.MapFrom(m => m.Description)).
                ForMember(vm => vm.imageByteArray, map => map.MapFrom(m => m.imageByteArray)).
                ForMember(vm=>vm.Products,map=>map.MapFrom(m=>m.Products)); 
            CreateMap<RecipeDTO, Recipe>().
                ForMember(vm => vm.Id, map => map.MapFrom(m => m.Id)).
                ForMember(vm => vm.Maker.Id, map => map.MapFrom(m => m.IdUser)).
                ForMember(vm => vm.IsAccepted, map => map.MapFrom(m => m.IsAccepted)).
                ForMember(vm => vm.Kcal, map => map.MapFrom(m => m.Kcal)).
                ForMember(vm => vm.Carbohydrates, map => map.MapFrom(m => m.Carbohydrates)).
                ForMember(vm => vm.Fat, map => map.MapFrom(m => m.Fat)).
                ForMember(vm => vm.Proteins, map => map.MapFrom(m => m.Proteins)).
                ForMember(vm => vm.Name, map => map.MapFrom(m => m.Name)).
                ForMember(vm => vm.PreprationTime, map => map.MapFrom(m => m.PreprationTime)).
                ForMember(vm => vm.Category, map => map.MapFrom(m => m.Category)).
                ForMember(vm => vm.Description, map => map.MapFrom(m => m.Description)).
                ForMember(vm => vm.imageByteArray, map => map.MapFrom(m => m.imageByteArray)).
                ForMember(vm => vm.Products, map => map.MapFrom(m => m.Products));

            CreateMap<ProductForLarder, ProductDTO>().
                ForMember(vm => vm.Id, map => map.MapFrom(m=>m.Id)).
                ForMember(vm => vm.Amount, map=>map.MapFrom(m=>m.Amount)).
                ForMember(vm=>vm.Kcal , map=>map.MapFrom(m=>m.Kcal)).
                ForMember(vm => vm.Portion, map => map.MapFrom(m => m.Portion)).
                ForMember(vm => vm.Chain, map => map.MapFrom(m => m.Chain)).
                ForMember(vm => vm.IsAccepted, map => map.MapFrom(m => m.IsAccepted)).
                ForMember(vm => vm.PortionSize, map => map.MapFrom(m => m.PortionSize)).
                ForMember(vm => vm.IdUser, map => map.MapFrom(m => m.IdUser)).
                ForMember(vm => vm.Name, map => map.MapFrom(m => m.Name)).
                ForMember(vm => vm.Fat, map => map.MapFrom(m => m.Fat)).
                ForMember(vm => vm.Carbohydrates, map => map.MapFrom(m => m.Carbohydrates)).
                ForMember(vm => vm.Proteins, map => map.MapFrom(m => m.Proteins)).
                ForMember(vm => vm.Category, map => map.MapFrom(m => m.Category));
            CreateMap< ProductDTO, ProductForLarder>().
                ForMember(vm => vm.Id, map => map.MapFrom(m => m.Id)).
                ForMember(vm => vm.Amount, map => map.MapFrom(m => m.Amount)).
                ForMember(vm => vm.Kcal, map => map.MapFrom(m => m.Kcal)).
                ForMember(vm => vm.Portion, map => map.MapFrom(m => m.Portion)).
                ForMember(vm => vm.Chain, map => map.MapFrom(m => m.Chain)).
                ForMember(vm => vm.IsAccepted, map => map.MapFrom(m => m.IsAccepted)).
                ForMember(vm => vm.PortionSize, map => map.MapFrom(m => m.PortionSize)).
                ForMember(vm => vm.IdUser, map => map.MapFrom(m => m.IdUser)).
                ForMember(vm => vm.Name, map => map.MapFrom(m => m.Name)).
                ForMember(vm => vm.Fat, map => map.MapFrom(m => m.Fat)).
                ForMember(vm => vm.Carbohydrates, map => map.MapFrom(m => m.Carbohydrates)).
                ForMember(vm => vm.Proteins, map => map.MapFrom(m => m.Proteins)).
                ForMember(vm => vm.Category, map => map.MapFrom(m => m.Category));

            CreateMap<ProductForRecipe, ProductDTO>().
                ForMember(vm => vm.Id, map => map.MapFrom(m=>m.Id)).
                ForMember(vm => vm.Amount, map=>map.MapFrom(m=>m.Amount)).
                ForMember(vm=>vm.Kcal , map=>map.MapFrom(m=>m.Kcal)).
                ForMember(vm => vm.Portion, map => map.MapFrom(m => m.Portion)).
                ForMember(vm => vm.Chain, map => map.MapFrom(m => m.Chain)).
                ForMember(vm => vm.IsAccepted, map => map.MapFrom(m => m.IsAccepted)).
                ForMember(vm => vm.PortionSize, map => map.MapFrom(m => m.PortionSize)).
                ForMember(vm => vm.IdUser, map => map.MapFrom(m => m.IdUser)).
                ForMember(vm => vm.Name, map => map.MapFrom(m => m.Name)).
                ForMember(vm => vm.Fat, map => map.MapFrom(m => m.Fat)).
                ForMember(vm => vm.Carbohydrates, map => map.MapFrom(m => m.Carbohydrates)).
                ForMember(vm => vm.Proteins, map => map.MapFrom(m => m.Proteins)).
                ForMember(vm => vm.Category, map => map.MapFrom(m => m.Category));
            CreateMap< ProductDTO, ProductForRecipe>().
                ForMember(vm => vm.Id, map => map.MapFrom(m => m.Id)).
                ForMember(vm => vm.Amount, map => map.MapFrom(m => m.Amount)).
                ForMember(vm => vm.Kcal, map => map.MapFrom(m => m.Kcal)).
                ForMember(vm => vm.Portion, map => map.MapFrom(m => m.Portion)).
                ForMember(vm => vm.Chain, map => map.MapFrom(m => m.Chain)).
                ForMember(vm => vm.IsAccepted, map => map.MapFrom(m => m.IsAccepted)).
                ForMember(vm => vm.PortionSize, map => map.MapFrom(m => m.PortionSize)).
                ForMember(vm => vm.IdUser, map => map.MapFrom(m => m.IdUser)).
                ForMember(vm => vm.Name, map => map.MapFrom(m => m.Name)).
                ForMember(vm => vm.Fat, map => map.MapFrom(m => m.Fat)).
                ForMember(vm => vm.Carbohydrates, map => map.MapFrom(m => m.Carbohydrates)).
                ForMember(vm => vm.Proteins, map => map.MapFrom(m => m.Proteins)).
                ForMember(vm => vm.Category, map => map.MapFrom(m => m.Category));
        }
    }
}
