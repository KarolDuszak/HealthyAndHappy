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
                ForMember(vm => vm.Date, map => map.MapFrom(m => m.Date));
            CreateMap<HistoryDTO, History>().
                ForMember(vm => vm.Id, map => map.MapFrom(m => m.Id)).
                ForMember(vm => vm.Kcal, map => map.MapFrom(m => m.Id)).
                ForMember(vm => vm.Recipe, map => map.MapFrom(m => m.Recipe)).
                ForMember(vm => vm.Date, map => map.MapFrom(m => m.Date));

            CreateMap<Larder, LarderDTO>().
                ForMember(vm => vm.Id, map => map.MapFrom(m => m.Id)).
                ForMember(vm => vm.User, map => map.MapFrom(m => m.User)).
                ForMember(vm => vm.Meats, map => map.MapFrom(m => m.Meats)).
                ForMember(vm => vm.Nuts, map => map.MapFrom(m => m.Nuts)).
                ForMember(vm => vm.Sauces, map => map.MapFrom(m => m.Sauces)).
                ForMember(vm => vm.Specials, map => map.MapFrom(m => m.Specials)).
                ForMember(vm => vm.Spices, map => map.MapFrom(m => m.Spices)).
                ForMember(vm => vm.Vegetables, map => map.MapFrom(m => m.Vegetables)).
                ForMember(vm => vm.Alcohols, map => map.MapFrom(m => m.Alcohols)).
                ForMember(vm => vm.BreadsAndNoodles, map => map.MapFrom(m => m.BreadsAndNoodles)).
                ForMember(vm => vm.Diaries, map => map.MapFrom(m => m.Diaries)).
                ForMember(vm => vm.Drinks, map => map.MapFrom(m => m.Drinks)).
                ForMember(vm => vm.DryGoods, map => map.MapFrom(m => m.DryGoods)).
                ForMember(vm => vm.OilsAndFats, map => map.MapFrom(m => m.OilsAndFats)).
                ForMember(vm => vm.FishAndSeafoods, map => map.MapFrom(m => m.FishAndSeafoods)).
                ForMember(vm => vm.Fruits, map => map.MapFrom(m => m.Fruits));
            CreateMap<LarderDTO,Larder>().
                ForMember(vm => vm.Id, map => map.MapFrom(m => m.Id)).
                ForMember(vm=>vm.User,map =>map.MapFrom(m=>m.User)).
                ForMember(vm => vm.Meats, map => map.MapFrom(m => m.Meats)).
                ForMember(vm => vm.Nuts, map => map.MapFrom(m => m.Nuts)).
                ForMember(vm => vm.Sauces, map => map.MapFrom(m => m.Sauces)).
                ForMember(vm => vm.Specials, map => map.MapFrom(m => m.Specials)).
                ForMember(vm => vm.Spices, map => map.MapFrom(m => m.Spices)).
                ForMember(vm => vm.Vegetables, map => map.MapFrom(m => m.Vegetables)).
                ForMember(vm => vm.Alcohols, map => map.MapFrom(m => m.Alcohols)).
                ForMember(vm => vm.BreadsAndNoodles, map => map.MapFrom(m => m.BreadsAndNoodles)).
                ForMember(vm => vm.Diaries, map => map.MapFrom(m => m.Diaries)).
                ForMember(vm => vm.Drinks, map => map.MapFrom(m => m.Drinks)).
                ForMember(vm => vm.DryGoods, map => map.MapFrom(m => m.DryGoods)).
                ForMember(vm => vm.OilsAndFats, map => map.MapFrom(m => m.OilsAndFats)).
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

            CreateMap<Recipe, RecipeDTO>().
                ForMember(vm => vm.Id, map => map.MapFrom(m => m.Id)).
                ForMember(vm => vm.IdUser, map => map.MapFrom(m => m.Maker.Id)).
                ForMember(vm => vm.IsAccepted, map => map.MapFrom(m => m.IsAccepted)).
                ForMember(vm => vm.Kcal, map => map.MapFrom(m => m.Kcal)).
                ForMember(vm => vm.Carbohydrates, map => map.MapFrom(m => m.Carbohydrates)).
                ForMember(vm => vm.Fat, map => map.MapFrom(m => m.Fat)).
                ForMember(vm => vm.Proteins, map => map.MapFrom(m => m.Proteins)).
                ForMember(vm => vm.Meats, map => map.MapFrom(m => m.Meats)).
                ForMember(vm => vm.Name, map => map.MapFrom(m => m.Name)).
                ForMember(vm => vm.Nuts, map => map.MapFrom(m => m.Nuts)).
                ForMember(vm => vm.PreprationTime, map => map.MapFrom(m => m.PreprationTime)).
                ForMember(vm => vm.Sauces, map => map.MapFrom(m => m.Sauces)).
                ForMember(vm => vm.Specials, map => map.MapFrom(m => m.Specials)).
                ForMember(vm => vm.Spices, map => map.MapFrom(m => m.Spices)).
                ForMember(vm => vm.Vegetables, map => map.MapFrom(m => m.Vegetables)).
                ForMember(vm => vm.Alcohols, map => map.MapFrom(m => m.Alcohols)).
                ForMember(vm => vm.BreadsAndNoodles, map => map.MapFrom(m => m.BreadsAndNoodles)).
                ForMember(vm => vm.Category, map => map.MapFrom(m => m.Category)).
                ForMember(vm => vm.Description, map => map.MapFrom(m => m.Description)).
                ForMember(vm => vm.Diaries, map => map.MapFrom(m => m.Diaries)).
                ForMember(vm => vm.Drinks, map => map.MapFrom(m => m.Drinks)).
                ForMember(vm => vm.DryGoods, map => map.MapFrom(m => m.DryGoods)).
                ForMember(vm => vm.OilsAndFats, map => map.MapFrom(m => m.OilsAndFats)).
                ForMember(vm => vm.FishAndSeafoods, map => map.MapFrom(m => m.FishAndSeafoods)).
                ForMember(vm => vm.Fruits, map => map.MapFrom(m => m.Fruits)).
                ForMember(vm => vm.imageByteArray, map => map.MapFrom(m => m.imageByteArray)); 
            CreateMap<RecipeDTO, Recipe>().
                ForMember(vm => vm.Id, map => map.MapFrom(m => m.Id)).
                ForMember(vm => vm.Maker.Id, map => map.MapFrom(m => m.IdUser)).
                ForMember(vm => vm.IsAccepted, map => map.MapFrom(m => m.IsAccepted)).
                ForMember(vm => vm.Kcal, map => map.MapFrom(m => m.Kcal)).
                ForMember(vm => vm.Carbohydrates, map => map.MapFrom(m => m.Carbohydrates)).
                ForMember(vm => vm.Fat, map => map.MapFrom(m => m.Fat)).
                ForMember(vm => vm.Proteins, map => map.MapFrom(m => m.Proteins)).
                ForMember(vm => vm.Meats, map => map.MapFrom(m => m.Meats)).
                ForMember(vm => vm.Name, map => map.MapFrom(m => m.Name)).
                ForMember(vm => vm.Nuts, map => map.MapFrom(m => m.Nuts)).
                ForMember(vm => vm.PreprationTime, map => map.MapFrom(m => m.PreprationTime)).
                ForMember(vm => vm.Sauces, map => map.MapFrom(m => m.Sauces)).
                ForMember(vm => vm.Specials, map => map.MapFrom(m => m.Specials)).
                ForMember(vm => vm.Spices, map => map.MapFrom(m => m.Spices)).
                ForMember(vm => vm.Vegetables, map => map.MapFrom(m => m.Vegetables)).
                ForMember(vm => vm.Alcohols, map => map.MapFrom(m => m.Alcohols)).
                ForMember(vm => vm.BreadsAndNoodles, map => map.MapFrom(m => m.BreadsAndNoodles)).
                ForMember(vm => vm.Category, map => map.MapFrom(m => m.Category)).
                ForMember(vm => vm.Description, map => map.MapFrom(m => m.Description)).
                ForMember(vm => vm.Diaries, map => map.MapFrom(m => m.Diaries)).
                ForMember(vm => vm.Drinks, map => map.MapFrom(m => m.Drinks)).
                ForMember(vm => vm.DryGoods, map => map.MapFrom(m => m.DryGoods)).
                ForMember(vm => vm.OilsAndFats, map => map.MapFrom(m => m.OilsAndFats)).
                ForMember(vm => vm.FishAndSeafoods, map => map.MapFrom(m => m.FishAndSeafoods)).
                ForMember(vm => vm.Fruits, map => map.MapFrom(m => m.Fruits)).
                ForMember(vm => vm.imageByteArray, map => map.MapFrom(m => m.imageByteArray));

            CreateMap<Alcohol, ProductDTO>().
                ForMember(vm => vm.Amount, map => map.MapFrom(m => m.Amount)).
                ForMember(vm => vm.Carbohydrates, map => map.MapFrom(m => m.Carbohydrates)).
                ForMember(vm => vm.Chain, map => map.MapFrom(m => m.Chain)).
                ForMember(vm => vm.Fat, map => map.MapFrom(m => m.Fat)).
                ForMember(vm => vm.Id, map => map.MapFrom(m => m.Id)).
                ForMember(vm => vm.IdUser, map => map.MapFrom(m => m.IdUser)).
                ForMember(vm => vm.IsAccepted, map => map.MapFrom(m => m.IsAccepted)).
                ForMember(vm => vm.Kcal, map => map.MapFrom(m => m.Kcal)).
                ForMember(vm => vm.Name, map => map.MapFrom(m => m.Name)).
                ForMember(vm => vm.Portion, map => map.MapFrom(m => m.Portion)).
                ForMember(vm => vm.PortionSize, map => map.MapFrom(m => m.PortionSize)).
                ForMember(vm => vm.Proteins, map => map.MapFrom(m => m.Proteins));
            CreateMap<ProductDTO,Alcohol>().
                ForMember(vm => vm.Amount, map => map.MapFrom(m => m.Amount)).
                ForMember(vm => vm.Carbohydrates, map => map.MapFrom(m => m.Carbohydrates)).
                ForMember(vm => vm.Chain, map => map.MapFrom(m => m.Chain)).
                ForMember(vm => vm.Fat, map => map.MapFrom(m => m.Fat)).
                ForMember(vm => vm.Id, map => map.MapFrom(m => m.Id)).
                ForMember(vm => vm.IdUser, map => map.MapFrom(m => m.IdUser)).
                ForMember(vm => vm.IsAccepted, map => map.MapFrom(m => m.IsAccepted)).
                ForMember(vm => vm.Kcal, map => map.MapFrom(m => m.Kcal)).
                ForMember(vm => vm.Name, map => map.MapFrom(m => m.Name)).
                ForMember(vm => vm.Portion, map => map.MapFrom(m => m.Portion)).
                ForMember(vm => vm.PortionSize, map => map.MapFrom(m => m.PortionSize)).
                ForMember(vm => vm.Proteins, map => map.MapFrom(m => m.Proteins));

            CreateMap<BreadAndNoodle, ProductDTO>().
                ForMember(vm => vm.Amount, map => map.MapFrom(m => m.Amount)).
                ForMember(vm => vm.Carbohydrates, map => map.MapFrom(m => m.Carbohydrates)).
                ForMember(vm => vm.Chain, map => map.MapFrom(m => m.Chain)).
                ForMember(vm => vm.Fat, map => map.MapFrom(m => m.Fat)).
                ForMember(vm => vm.Id, map => map.MapFrom(m => m.Id)).
                ForMember(vm => vm.IdUser, map => map.MapFrom(m => m.IdUser)).
                ForMember(vm => vm.IsAccepted, map => map.MapFrom(m => m.IsAccepted)).
                ForMember(vm => vm.Kcal, map => map.MapFrom(m => m.Kcal)).
                ForMember(vm => vm.Name, map => map.MapFrom(m => m.Name)).
                ForMember(vm => vm.Portion, map => map.MapFrom(m => m.Portion)).
                ForMember(vm => vm.PortionSize, map => map.MapFrom(m => m.PortionSize)).
                ForMember(vm => vm.Proteins, map => map.MapFrom(m => m.Proteins));
            CreateMap<ProductDTO, BreadAndNoodle>().
                ForMember(vm => vm.Amount, map => map.MapFrom(m => m.Amount)).
                ForMember(vm => vm.Carbohydrates, map => map.MapFrom(m => m.Carbohydrates)).
                ForMember(vm => vm.Chain, map => map.MapFrom(m => m.Chain)).
                ForMember(vm => vm.Fat, map => map.MapFrom(m => m.Fat)).
                ForMember(vm => vm.Id, map => map.MapFrom(m => m.Id)).
                ForMember(vm => vm.IdUser, map => map.MapFrom(m => m.IdUser)).
                ForMember(vm => vm.IsAccepted, map => map.MapFrom(m => m.IsAccepted)).
                ForMember(vm => vm.Kcal, map => map.MapFrom(m => m.Kcal)).
                ForMember(vm => vm.Name, map => map.MapFrom(m => m.Name)).
                ForMember(vm => vm.Portion, map => map.MapFrom(m => m.Portion)).
                ForMember(vm => vm.PortionSize, map => map.MapFrom(m => m.PortionSize)).
                ForMember(vm => vm.Proteins, map => map.MapFrom(m => m.Proteins));

            CreateMap<Diary, ProductDTO>().
                ForMember(vm => vm.Amount, map => map.MapFrom(m => m.Amount)).
                ForMember(vm => vm.Carbohydrates, map => map.MapFrom(m => m.Carbohydrates)).
                ForMember(vm => vm.Chain, map => map.MapFrom(m => m.Chain)).
                ForMember(vm => vm.Fat, map => map.MapFrom(m => m.Fat)).
                ForMember(vm => vm.Id, map => map.MapFrom(m => m.Id)).
                ForMember(vm => vm.IdUser, map => map.MapFrom(m => m.IdUser)).
                ForMember(vm => vm.IsAccepted, map => map.MapFrom(m => m.IsAccepted)).
                ForMember(vm => vm.Kcal, map => map.MapFrom(m => m.Kcal)).
                ForMember(vm => vm.Name, map => map.MapFrom(m => m.Name)).
                ForMember(vm => vm.Portion, map => map.MapFrom(m => m.Portion)).
                ForMember(vm => vm.PortionSize, map => map.MapFrom(m => m.PortionSize)).
                ForMember(vm => vm.Proteins, map => map.MapFrom(m => m.Proteins));
            CreateMap<ProductDTO, Diary>().
                ForMember(vm => vm.Amount, map => map.MapFrom(m => m.Amount)).
                ForMember(vm => vm.Carbohydrates, map => map.MapFrom(m => m.Carbohydrates)).
                ForMember(vm => vm.Chain, map => map.MapFrom(m => m.Chain)).
                ForMember(vm => vm.Fat, map => map.MapFrom(m => m.Fat)).
                ForMember(vm => vm.Id, map => map.MapFrom(m => m.Id)).
                ForMember(vm => vm.IdUser, map => map.MapFrom(m => m.IdUser)).
                ForMember(vm => vm.IsAccepted, map => map.MapFrom(m => m.IsAccepted)).
                ForMember(vm => vm.Kcal, map => map.MapFrom(m => m.Kcal)).
                ForMember(vm => vm.Name, map => map.MapFrom(m => m.Name)).
                ForMember(vm => vm.Portion, map => map.MapFrom(m => m.Portion)).
                ForMember(vm => vm.PortionSize, map => map.MapFrom(m => m.PortionSize)).
                ForMember(vm => vm.Proteins, map => map.MapFrom(m => m.Proteins));

            CreateMap<Drink, ProductDTO>().
                ForMember(vm => vm.Amount, map => map.MapFrom(m => m.Amount)).
                ForMember(vm => vm.Carbohydrates, map => map.MapFrom(m => m.Carbohydrates)).
                ForMember(vm => vm.Chain, map => map.MapFrom(m => m.Chain)).
                ForMember(vm => vm.Fat, map => map.MapFrom(m => m.Fat)).
                ForMember(vm => vm.Id, map => map.MapFrom(m => m.Id)).
                ForMember(vm => vm.IdUser, map => map.MapFrom(m => m.IdUser)).
                ForMember(vm => vm.IsAccepted, map => map.MapFrom(m => m.IsAccepted)).
                ForMember(vm => vm.Kcal, map => map.MapFrom(m => m.Kcal)).
                ForMember(vm => vm.Name, map => map.MapFrom(m => m.Name)).
                ForMember(vm => vm.Portion, map => map.MapFrom(m => m.Portion)).
                ForMember(vm => vm.PortionSize, map => map.MapFrom(m => m.PortionSize)).
                ForMember(vm => vm.Proteins, map => map.MapFrom(m => m.Proteins));
            CreateMap<ProductDTO, Drink>().
                ForMember(vm => vm.Amount, map => map.MapFrom(m => m.Amount)).
                ForMember(vm => vm.Carbohydrates, map => map.MapFrom(m => m.Carbohydrates)).
                ForMember(vm => vm.Chain, map => map.MapFrom(m => m.Chain)).
                ForMember(vm => vm.Fat, map => map.MapFrom(m => m.Fat)).
                ForMember(vm => vm.Id, map => map.MapFrom(m => m.Id)).
                ForMember(vm => vm.IdUser, map => map.MapFrom(m => m.IdUser)).
                ForMember(vm => vm.IsAccepted, map => map.MapFrom(m => m.IsAccepted)).
                ForMember(vm => vm.Kcal, map => map.MapFrom(m => m.Kcal)).
                ForMember(vm => vm.Name, map => map.MapFrom(m => m.Name)).
                ForMember(vm => vm.Portion, map => map.MapFrom(m => m.Portion)).
                ForMember(vm => vm.PortionSize, map => map.MapFrom(m => m.PortionSize)).
                ForMember(vm => vm.Proteins, map => map.MapFrom(m => m.Proteins));

            CreateMap<DryGood,ProductDTO>().
                ForMember(vm => vm.Amount, map => map.MapFrom(m => m.Amount)).
                ForMember(vm => vm.Carbohydrates, map => map.MapFrom(m => m.Carbohydrates)).
                ForMember(vm => vm.Chain, map => map.MapFrom(m => m.Chain)).
                ForMember(vm => vm.Fat, map => map.MapFrom(m => m.Fat)).
                ForMember(vm => vm.Id, map => map.MapFrom(m => m.Id)).
                ForMember(vm => vm.IdUser, map => map.MapFrom(m => m.IdUser)).
                ForMember(vm => vm.IsAccepted, map => map.MapFrom(m => m.IsAccepted)).
                ForMember(vm => vm.Kcal, map => map.MapFrom(m => m.Kcal)).
                ForMember(vm => vm.Name, map => map.MapFrom(m => m.Name)).
                ForMember(vm => vm.Portion, map => map.MapFrom(m => m.Portion)).
                ForMember(vm => vm.PortionSize, map => map.MapFrom(m => m.PortionSize)).
                ForMember(vm => vm.Proteins, map => map.MapFrom(m => m.Proteins));
            CreateMap<ProductDTO,DryGood>().
                ForMember(vm => vm.Amount, map => map.MapFrom(m => m.Amount)).
                ForMember(vm => vm.Carbohydrates, map => map.MapFrom(m => m.Carbohydrates)).
                ForMember(vm => vm.Chain, map => map.MapFrom(m => m.Chain)).
                ForMember(vm => vm.Fat, map => map.MapFrom(m => m.Fat)).
                ForMember(vm => vm.Id, map => map.MapFrom(m => m.Id)).
                ForMember(vm => vm.IdUser, map => map.MapFrom(m => m.IdUser)).
                ForMember(vm => vm.IsAccepted, map => map.MapFrom(m => m.IsAccepted)).
                ForMember(vm => vm.Kcal, map => map.MapFrom(m => m.Kcal)).
                ForMember(vm => vm.Name, map => map.MapFrom(m => m.Name)).
                ForMember(vm => vm.Portion, map => map.MapFrom(m => m.Portion)).
                ForMember(vm => vm.PortionSize, map => map.MapFrom(m => m.PortionSize)).
                ForMember(vm => vm.Proteins, map => map.MapFrom(m => m.Proteins));

            CreateMap<FishAndSeafood,ProductDTO>().
                ForMember(vm => vm.Amount, map => map.MapFrom(m => m.Amount)).
                ForMember(vm => vm.Carbohydrates, map => map.MapFrom(m => m.Carbohydrates)).
                ForMember(vm => vm.Chain, map => map.MapFrom(m => m.Chain)).
                ForMember(vm => vm.Fat, map => map.MapFrom(m => m.Fat)).
                ForMember(vm => vm.Id, map => map.MapFrom(m => m.Id)).
                ForMember(vm => vm.IdUser, map => map.MapFrom(m => m.IdUser)).
                ForMember(vm => vm.IsAccepted, map => map.MapFrom(m => m.IsAccepted)).
                ForMember(vm => vm.Kcal, map => map.MapFrom(m => m.Kcal)).
                ForMember(vm => vm.Name, map => map.MapFrom(m => m.Name)).
                ForMember(vm => vm.Portion, map => map.MapFrom(m => m.Portion)).
                ForMember(vm => vm.PortionSize, map => map.MapFrom(m => m.PortionSize)).
                ForMember(vm => vm.Proteins, map => map.MapFrom(m => m.Proteins));
            CreateMap<ProductDTO,FishAndSeafood>().
                ForMember(vm => vm.Amount, map => map.MapFrom(m => m.Amount)).
                ForMember(vm => vm.Carbohydrates, map => map.MapFrom(m => m.Carbohydrates)).
                ForMember(vm => vm.Chain, map => map.MapFrom(m => m.Chain)).
                ForMember(vm => vm.Fat, map => map.MapFrom(m => m.Fat)).
                ForMember(vm => vm.Id, map => map.MapFrom(m => m.Id)).
                ForMember(vm => vm.IdUser, map => map.MapFrom(m => m.IdUser)).
                ForMember(vm => vm.IsAccepted, map => map.MapFrom(m => m.IsAccepted)).
                ForMember(vm => vm.Kcal, map => map.MapFrom(m => m.Kcal)).
                ForMember(vm => vm.Name, map => map.MapFrom(m => m.Name)).
                ForMember(vm => vm.Portion, map => map.MapFrom(m => m.Portion)).
                ForMember(vm => vm.PortionSize, map => map.MapFrom(m => m.PortionSize)).
                ForMember(vm => vm.Proteins, map => map.MapFrom(m => m.Proteins));

            CreateMap<Fruit,ProductDTO>().
                ForMember(vm => vm.Amount, map => map.MapFrom(m => m.Amount)).
                ForMember(vm => vm.Carbohydrates, map => map.MapFrom(m => m.Carbohydrates)).
                ForMember(vm => vm.Chain, map => map.MapFrom(m => m.Chain)).
                ForMember(vm => vm.Fat, map => map.MapFrom(m => m.Fat)).
                ForMember(vm => vm.Id, map => map.MapFrom(m => m.Id)).
                ForMember(vm => vm.IdUser, map => map.MapFrom(m => m.IdUser)).
                ForMember(vm => vm.IsAccepted, map => map.MapFrom(m => m.IsAccepted)).
                ForMember(vm => vm.Kcal, map => map.MapFrom(m => m.Kcal)).
                ForMember(vm => vm.Name, map => map.MapFrom(m => m.Name)).
                ForMember(vm => vm.Portion, map => map.MapFrom(m => m.Portion)).
                ForMember(vm => vm.PortionSize, map => map.MapFrom(m => m.PortionSize)).
                ForMember(vm => vm.Proteins, map => map.MapFrom(m => m.Proteins));
            CreateMap<ProductDTO,Fruit>().
                ForMember(vm => vm.Amount, map => map.MapFrom(m => m.Amount)).
                ForMember(vm => vm.Carbohydrates, map => map.MapFrom(m => m.Carbohydrates)).
                ForMember(vm => vm.Chain, map => map.MapFrom(m => m.Chain)).
                ForMember(vm => vm.Fat, map => map.MapFrom(m => m.Fat)).
                ForMember(vm => vm.Id, map => map.MapFrom(m => m.Id)).
                ForMember(vm => vm.IdUser, map => map.MapFrom(m => m.IdUser)).
                ForMember(vm => vm.IsAccepted, map => map.MapFrom(m => m.IsAccepted)).
                ForMember(vm => vm.Kcal, map => map.MapFrom(m => m.Kcal)).
                ForMember(vm => vm.Name, map => map.MapFrom(m => m.Name)).
                ForMember(vm => vm.Portion, map => map.MapFrom(m => m.Portion)).
                ForMember(vm => vm.PortionSize, map => map.MapFrom(m => m.PortionSize)).
                ForMember(vm => vm.Proteins, map => map.MapFrom(m => m.Proteins));

            CreateMap<Meat,ProductDTO>().
                ForMember(vm => vm.Amount, map => map.MapFrom(m => m.Amount)).
                ForMember(vm => vm.Carbohydrates, map => map.MapFrom(m => m.Carbohydrates)).
                ForMember(vm => vm.Chain, map => map.MapFrom(m => m.Chain)).
                ForMember(vm => vm.Fat, map => map.MapFrom(m => m.Fat)).
                ForMember(vm => vm.Id, map => map.MapFrom(m => m.Id)).
                ForMember(vm => vm.IdUser, map => map.MapFrom(m => m.IdUser)).
                ForMember(vm => vm.IsAccepted, map => map.MapFrom(m => m.IsAccepted)).
                ForMember(vm => vm.Kcal, map => map.MapFrom(m => m.Kcal)).
                ForMember(vm => vm.Name, map => map.MapFrom(m => m.Name)).
                ForMember(vm => vm.Portion, map => map.MapFrom(m => m.Portion)).
                ForMember(vm => vm.PortionSize, map => map.MapFrom(m => m.PortionSize)).
                ForMember(vm => vm.Proteins, map => map.MapFrom(m => m.Proteins));
            CreateMap<ProductDTO,Meat>().
                ForMember(vm => vm.Amount, map => map.MapFrom(m => m.Amount)).
                ForMember(vm => vm.Carbohydrates, map => map.MapFrom(m => m.Carbohydrates)).
                ForMember(vm => vm.Chain, map => map.MapFrom(m => m.Chain)).
                ForMember(vm => vm.Fat, map => map.MapFrom(m => m.Fat)).
                ForMember(vm => vm.Id, map => map.MapFrom(m => m.Id)).
                ForMember(vm => vm.IdUser, map => map.MapFrom(m => m.IdUser)).
                ForMember(vm => vm.IsAccepted, map => map.MapFrom(m => m.IsAccepted)).
                ForMember(vm => vm.Kcal, map => map.MapFrom(m => m.Kcal)).
                ForMember(vm => vm.Name, map => map.MapFrom(m => m.Name)).
                ForMember(vm => vm.Portion, map => map.MapFrom(m => m.Portion)).
                ForMember(vm => vm.PortionSize, map => map.MapFrom(m => m.PortionSize)).
                ForMember(vm => vm.Proteins, map => map.MapFrom(m => m.Proteins));

            CreateMap<Nut,ProductDTO>().
                ForMember(vm => vm.Amount, map => map.MapFrom(m => m.Amount)).
                ForMember(vm => vm.Carbohydrates, map => map.MapFrom(m => m.Carbohydrates)).
                ForMember(vm => vm.Chain, map => map.MapFrom(m => m.Chain)).
                ForMember(vm => vm.Fat, map => map.MapFrom(m => m.Fat)).
                ForMember(vm => vm.Id, map => map.MapFrom(m => m.Id)).
                ForMember(vm => vm.IdUser, map => map.MapFrom(m => m.IdUser)).
                ForMember(vm => vm.IsAccepted, map => map.MapFrom(m => m.IsAccepted)).
                ForMember(vm => vm.Kcal, map => map.MapFrom(m => m.Kcal)).
                ForMember(vm => vm.Name, map => map.MapFrom(m => m.Name)).
                ForMember(vm => vm.Portion, map => map.MapFrom(m => m.Portion)).
                ForMember(vm => vm.PortionSize, map => map.MapFrom(m => m.PortionSize)).
                ForMember(vm => vm.Proteins, map => map.MapFrom(m => m.Proteins));
            CreateMap<ProductDTO,Nut>().
                ForMember(vm => vm.Amount, map => map.MapFrom(m => m.Amount)).
                ForMember(vm => vm.Carbohydrates, map => map.MapFrom(m => m.Carbohydrates)).
                ForMember(vm => vm.Chain, map => map.MapFrom(m => m.Chain)).
                ForMember(vm => vm.Fat, map => map.MapFrom(m => m.Fat)).
                ForMember(vm => vm.Id, map => map.MapFrom(m => m.Id)).
                ForMember(vm => vm.IdUser, map => map.MapFrom(m => m.IdUser)).
                ForMember(vm => vm.IsAccepted, map => map.MapFrom(m => m.IsAccepted)).
                ForMember(vm => vm.Kcal, map => map.MapFrom(m => m.Kcal)).
                ForMember(vm => vm.Name, map => map.MapFrom(m => m.Name)).
                ForMember(vm => vm.Portion, map => map.MapFrom(m => m.Portion)).
                ForMember(vm => vm.PortionSize, map => map.MapFrom(m => m.PortionSize)).
                ForMember(vm => vm.Proteins, map => map.MapFrom(m => m.Proteins));

            CreateMap<OilAndFat,ProductDTO>().
                ForMember(vm => vm.Amount, map => map.MapFrom(m => m.Amount)).
                ForMember(vm => vm.Carbohydrates, map => map.MapFrom(m => m.Carbohydrates)).
                ForMember(vm => vm.Chain, map => map.MapFrom(m => m.Chain)).
                ForMember(vm => vm.Fat, map => map.MapFrom(m => m.Fat)).
                ForMember(vm => vm.Id, map => map.MapFrom(m => m.Id)).
                ForMember(vm => vm.IdUser, map => map.MapFrom(m => m.IdUser)).
                ForMember(vm => vm.IsAccepted, map => map.MapFrom(m => m.IsAccepted)).
                ForMember(vm => vm.Kcal, map => map.MapFrom(m => m.Kcal)).
                ForMember(vm => vm.Name, map => map.MapFrom(m => m.Name)).
                ForMember(vm => vm.Portion, map => map.MapFrom(m => m.Portion)).
                ForMember(vm => vm.PortionSize, map => map.MapFrom(m => m.PortionSize)).
                ForMember(vm => vm.Proteins, map => map.MapFrom(m => m.Proteins));
            CreateMap<ProductDTO,OilAndFat>().
                ForMember(vm => vm.Amount, map => map.MapFrom(m => m.Amount)).
                ForMember(vm => vm.Carbohydrates, map => map.MapFrom(m => m.Carbohydrates)).
                ForMember(vm => vm.Chain, map => map.MapFrom(m => m.Chain)).
                ForMember(vm => vm.Fat, map => map.MapFrom(m => m.Fat)).
                ForMember(vm => vm.Id, map => map.MapFrom(m => m.Id)).
                ForMember(vm => vm.IdUser, map => map.MapFrom(m => m.IdUser)).
                ForMember(vm => vm.IsAccepted, map => map.MapFrom(m => m.IsAccepted)).
                ForMember(vm => vm.Kcal, map => map.MapFrom(m => m.Kcal)).
                ForMember(vm => vm.Name, map => map.MapFrom(m => m.Name)).
                ForMember(vm => vm.Portion, map => map.MapFrom(m => m.Portion)).
                ForMember(vm => vm.PortionSize, map => map.MapFrom(m => m.PortionSize)).
                ForMember(vm => vm.Proteins, map => map.MapFrom(m => m.Proteins));

            CreateMap<Sauce,ProductDTO>().
                ForMember(vm => vm.Amount, map => map.MapFrom(m => m.Amount)).
                ForMember(vm => vm.Carbohydrates, map => map.MapFrom(m => m.Carbohydrates)).
                ForMember(vm => vm.Chain, map => map.MapFrom(m => m.Chain)).
                ForMember(vm => vm.Fat, map => map.MapFrom(m => m.Fat)).
                ForMember(vm => vm.Id, map => map.MapFrom(m => m.Id)).
                ForMember(vm => vm.IdUser, map => map.MapFrom(m => m.IdUser)).
                ForMember(vm => vm.IsAccepted, map => map.MapFrom(m => m.IsAccepted)).
                ForMember(vm => vm.Kcal, map => map.MapFrom(m => m.Kcal)).
                ForMember(vm => vm.Name, map => map.MapFrom(m => m.Name)).
                ForMember(vm => vm.Portion, map => map.MapFrom(m => m.Portion)).
                ForMember(vm => vm.PortionSize, map => map.MapFrom(m => m.PortionSize)).
                ForMember(vm => vm.Proteins, map => map.MapFrom(m => m.Proteins));
            CreateMap<ProductDTO,Sauce>().
                ForMember(vm => vm.Amount, map => map.MapFrom(m => m.Amount)).
                ForMember(vm => vm.Carbohydrates, map => map.MapFrom(m => m.Carbohydrates)).
                ForMember(vm => vm.Chain, map => map.MapFrom(m => m.Chain)).
                ForMember(vm => vm.Fat, map => map.MapFrom(m => m.Fat)).
                ForMember(vm => vm.Id, map => map.MapFrom(m => m.Id)).
                ForMember(vm => vm.IdUser, map => map.MapFrom(m => m.IdUser)).
                ForMember(vm => vm.IsAccepted, map => map.MapFrom(m => m.IsAccepted)).
                ForMember(vm => vm.Kcal, map => map.MapFrom(m => m.Kcal)).
                ForMember(vm => vm.Name, map => map.MapFrom(m => m.Name)).
                ForMember(vm => vm.Portion, map => map.MapFrom(m => m.Portion)).
                ForMember(vm => vm.PortionSize, map => map.MapFrom(m => m.PortionSize)).
                ForMember(vm => vm.Proteins, map => map.MapFrom(m => m.Proteins));

            CreateMap<Special,ProductDTO>().
                ForMember(vm => vm.Amount, map => map.MapFrom(m => m.Amount)).
                ForMember(vm => vm.Carbohydrates, map => map.MapFrom(m => m.Carbohydrates)).
                ForMember(vm => vm.Chain, map => map.MapFrom(m => m.Chain)).
                ForMember(vm => vm.Fat, map => map.MapFrom(m => m.Fat)).
                ForMember(vm => vm.Id, map => map.MapFrom(m => m.Id)).
                ForMember(vm => vm.IdUser, map => map.MapFrom(m => m.IdUser)).
                ForMember(vm => vm.IsAccepted, map => map.MapFrom(m => m.IsAccepted)).
                ForMember(vm => vm.Kcal, map => map.MapFrom(m => m.Kcal)).
                ForMember(vm => vm.Name, map => map.MapFrom(m => m.Name)).
                ForMember(vm => vm.Portion, map => map.MapFrom(m => m.Portion)).
                ForMember(vm => vm.PortionSize, map => map.MapFrom(m => m.PortionSize)).
                ForMember(vm => vm.Proteins, map => map.MapFrom(m => m.Proteins));
            CreateMap<ProductDTO,Special>().
                ForMember(vm => vm.Amount, map => map.MapFrom(m => m.Amount)).
                ForMember(vm => vm.Carbohydrates, map => map.MapFrom(m => m.Carbohydrates)).
                ForMember(vm => vm.Chain, map => map.MapFrom(m => m.Chain)).
                ForMember(vm => vm.Fat, map => map.MapFrom(m => m.Fat)).
                ForMember(vm => vm.Id, map => map.MapFrom(m => m.Id)).
                ForMember(vm => vm.IdUser, map => map.MapFrom(m => m.IdUser)).
                ForMember(vm => vm.IsAccepted, map => map.MapFrom(m => m.IsAccepted)).
                ForMember(vm => vm.Kcal, map => map.MapFrom(m => m.Kcal)).
                ForMember(vm => vm.Name, map => map.MapFrom(m => m.Name)).
                ForMember(vm => vm.Portion, map => map.MapFrom(m => m.Portion)).
                ForMember(vm => vm.PortionSize, map => map.MapFrom(m => m.PortionSize)).
                ForMember(vm => vm.Proteins, map => map.MapFrom(m => m.Proteins));

            CreateMap<Spice,ProductDTO>().
                ForMember(vm => vm.Amount, map => map.MapFrom(m => m.Amount)).
                ForMember(vm => vm.Carbohydrates, map => map.MapFrom(m => m.Carbohydrates)).
                ForMember(vm => vm.Chain, map => map.MapFrom(m => m.Chain)).
                ForMember(vm => vm.Fat, map => map.MapFrom(m => m.Fat)).
                ForMember(vm => vm.Id, map => map.MapFrom(m => m.Id)).
                ForMember(vm => vm.IdUser, map => map.MapFrom(m => m.IdUser)).
                ForMember(vm => vm.IsAccepted, map => map.MapFrom(m => m.IsAccepted)).
                ForMember(vm => vm.Kcal, map => map.MapFrom(m => m.Kcal)).
                ForMember(vm => vm.Name, map => map.MapFrom(m => m.Name)).
                ForMember(vm => vm.Portion, map => map.MapFrom(m => m.Portion)).
                ForMember(vm => vm.PortionSize, map => map.MapFrom(m => m.PortionSize)).
                ForMember(vm => vm.Proteins, map => map.MapFrom(m => m.Proteins));
            CreateMap<ProductDTO,Spice>().
                ForMember(vm => vm.Amount, map => map.MapFrom(m => m.Amount)).
                ForMember(vm => vm.Carbohydrates, map => map.MapFrom(m => m.Carbohydrates)).
                ForMember(vm => vm.Chain, map => map.MapFrom(m => m.Chain)).
                ForMember(vm => vm.Fat, map => map.MapFrom(m => m.Fat)).
                ForMember(vm => vm.Id, map => map.MapFrom(m => m.Id)).
                ForMember(vm => vm.IdUser, map => map.MapFrom(m => m.IdUser)).
                ForMember(vm => vm.IsAccepted, map => map.MapFrom(m => m.IsAccepted)).
                ForMember(vm => vm.Kcal, map => map.MapFrom(m => m.Kcal)).
                ForMember(vm => vm.Name, map => map.MapFrom(m => m.Name)).
                ForMember(vm => vm.Portion, map => map.MapFrom(m => m.Portion)).
                ForMember(vm => vm.PortionSize, map => map.MapFrom(m => m.PortionSize)).
                ForMember(vm => vm.Proteins, map => map.MapFrom(m => m.Proteins));

            CreateMap<Vegetable,ProductDTO>().
                ForMember(vm => vm.Amount, map => map.MapFrom(m => m.Amount)).
                ForMember(vm => vm.Carbohydrates, map => map.MapFrom(m => m.Carbohydrates)).
                ForMember(vm => vm.Chain, map => map.MapFrom(m => m.Chain)).
                ForMember(vm => vm.Fat, map => map.MapFrom(m => m.Fat)).
                ForMember(vm => vm.Id, map => map.MapFrom(m => m.Id)).
                ForMember(vm => vm.IdUser, map => map.MapFrom(m => m.IdUser)).
                ForMember(vm => vm.IsAccepted, map => map.MapFrom(m => m.IsAccepted)).
                ForMember(vm => vm.Kcal, map => map.MapFrom(m => m.Kcal)).
                ForMember(vm => vm.Name, map => map.MapFrom(m => m.Name)).
                ForMember(vm => vm.Portion, map => map.MapFrom(m => m.Portion)).
                ForMember(vm => vm.PortionSize, map => map.MapFrom(m => m.PortionSize)).
                ForMember(vm => vm.Proteins, map => map.MapFrom(m => m.Proteins));
            CreateMap<ProductDTO,Vegetable>().
                ForMember(vm => vm.Amount, map => map.MapFrom(m => m.Amount)).
                ForMember(vm => vm.Carbohydrates, map => map.MapFrom(m => m.Carbohydrates)).
                ForMember(vm => vm.Chain, map => map.MapFrom(m => m.Chain)).
                ForMember(vm => vm.Fat, map => map.MapFrom(m => m.Fat)).
                ForMember(vm => vm.Id, map => map.MapFrom(m => m.Id)).
                ForMember(vm => vm.IdUser, map => map.MapFrom(m => m.IdUser)).
                ForMember(vm => vm.IsAccepted, map => map.MapFrom(m => m.IsAccepted)).
                ForMember(vm => vm.Kcal, map => map.MapFrom(m => m.Kcal)).
                ForMember(vm => vm.Name, map => map.MapFrom(m => m.Name)).
                ForMember(vm => vm.Portion, map => map.MapFrom(m => m.Portion)).
                ForMember(vm => vm.PortionSize, map => map.MapFrom(m => m.PortionSize)).
                ForMember(vm => vm.Proteins, map => map.MapFrom(m => m.Proteins));
        }
    }
}
