﻿// <auto-generated />
using System;
using DateAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(практическая_работаContext))]
    partial class практическая_работаContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Domain.Models.Activity", b =>
                {
                    b.Property<int>("ActivityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ActivityID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ActivityId"), 1L, 1);

                    b.Property<string>("ActivityName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("CaloriesBurned")
                        .HasColumnType("int");

                    b.Property<int?>("Duration")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("UserID");

                    b.HasKey("ActivityId");

                    b.HasIndex("UserId");

                    b.ToTable("Activities");
                });

            modelBuilder.Entity("Domain.Models.Allergen", b =>
                {
                    b.Property<int>("AllergenId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("AllergenID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AllergenId"), 1L, 1);

                    b.Property<string>("AllergenName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AllergenId");

                    b.ToTable("Allergens");
                });

            modelBuilder.Entity("Domain.Models.FavoriteRecipe", b =>
                {
                    b.Property<int>("FavoriteRecipeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("FavoriteRecipeID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FavoriteRecipeId"), 1L, 1);

                    b.Property<int?>("RecipeId")
                        .HasColumnType("int")
                        .HasColumnName("RecipeID");

                    b.Property<int?>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("UserID");

                    b.HasKey("FavoriteRecipeId");

                    b.HasIndex("RecipeId");

                    b.HasIndex("UserId");

                    b.ToTable("FavoriteRecipes");
                });

            modelBuilder.Entity("Domain.Models.FoodAllergen", b =>
                {
                    b.Property<int>("FoodAllergenId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("FoodAllergenID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FoodAllergenId"), 1L, 1);

                    b.Property<int?>("AllergenId")
                        .HasColumnType("int")
                        .HasColumnName("AllergenID");

                    b.Property<int?>("FoodItemId")
                        .HasColumnType("int")
                        .HasColumnName("FoodItemID");

                    b.HasKey("FoodAllergenId");

                    b.HasIndex("AllergenId");

                    b.HasIndex("FoodItemId");

                    b.ToTable("FoodAllergens");
                });

            modelBuilder.Entity("Domain.Models.FoodCategory", b =>
                {
                    b.Property<int>("FoodCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("FoodCategoryID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FoodCategoryId"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("FoodCategoryId");

                    b.ToTable("FoodCategories");
                });

            modelBuilder.Entity("Domain.Models.FoodItem", b =>
                {
                    b.Property<int>("FoodItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("FoodItemID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FoodItemId"), 1L, 1);

                    b.Property<int?>("Calories")
                        .HasColumnType("int");

                    b.Property<decimal?>("Carbohydrates")
                        .HasColumnType("decimal(5,2)");

                    b.Property<decimal?>("Fats")
                        .HasColumnType("decimal(5,2)");

                    b.Property<string>("FoodName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal?>("Protein")
                        .HasColumnType("decimal(5,2)");

                    b.HasKey("FoodItemId");

                    b.ToTable("FoodItems");
                });

            modelBuilder.Entity("Domain.Models.FoodItemCategory", b =>
                {
                    b.Property<int>("FoodItemCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("FoodItemCategoryID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FoodItemCategoryId"), 1L, 1);

                    b.Property<int?>("FoodCategoryId")
                        .HasColumnType("int")
                        .HasColumnName("FoodCategoryID");

                    b.Property<int?>("FoodItemId")
                        .HasColumnType("int")
                        .HasColumnName("FoodItemID");

                    b.HasKey("FoodItemCategoryId");

                    b.HasIndex("FoodCategoryId");

                    b.HasIndex("FoodItemId");

                    b.ToTable("FoodItemCategories");
                });

            modelBuilder.Entity("Domain.Models.Meal", b =>
                {
                    b.Property<int>("MealId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("MealID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MealId"), 1L, 1);

                    b.Property<DateTime?>("MealDate")
                        .HasColumnType("date");

                    b.Property<int?>("MealPlanId")
                        .HasColumnType("int")
                        .HasColumnName("MealPlanID");

                    b.Property<string>("MealType")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("MealId");

                    b.HasIndex("MealPlanId");

                    b.ToTable("Meals");
                });

            modelBuilder.Entity("Domain.Models.MealFoodItem", b =>
                {
                    b.Property<int>("MealFoodItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("MealFoodItemID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MealFoodItemId"), 1L, 1);

                    b.Property<int?>("FoodItemId")
                        .HasColumnType("int")
                        .HasColumnName("FoodItemID");

                    b.Property<int?>("MealId")
                        .HasColumnType("int")
                        .HasColumnName("MealID");

                    b.Property<decimal?>("ServingSize")
                        .HasColumnType("decimal(5,2)");

                    b.HasKey("MealFoodItemId");

                    b.HasIndex("FoodItemId");

                    b.HasIndex("MealId");

                    b.ToTable("MealFoodItems");
                });

            modelBuilder.Entity("Domain.Models.MealPlan", b =>
                {
                    b.Property<int>("MealPlanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("MealPlanID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MealPlanId"), 1L, 1);

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("date");

                    b.Property<string>("PlanName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("date");

                    b.Property<int?>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("UserID");

                    b.HasKey("MealPlanId");

                    b.HasIndex("UserId");

                    b.ToTable("MealPlans");
                });

            modelBuilder.Entity("Domain.Models.NutritionalGoal", b =>
                {
                    b.Property<int>("GoalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("GoalID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GoalId"), 1L, 1);

                    b.Property<decimal?>("CarbohydrateGoal")
                        .HasColumnType("decimal(5,2)");

                    b.Property<int?>("DailyCaloricIntake")
                        .HasColumnType("int");

                    b.Property<decimal?>("FatGoal")
                        .HasColumnType("decimal(5,2)");

                    b.Property<decimal?>("ProteinGoal")
                        .HasColumnType("decimal(5,2)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("UserID");

                    b.HasKey("GoalId")
                        .HasName("PK__Nutritio__8A4FFF31ADAF2519");

                    b.HasIndex("UserId");

                    b.ToTable("NutritionalGoals");
                });

            modelBuilder.Entity("Domain.Models.Profile", b =>
                {
                    b.Property<int>("ProfileId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ProfileID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProfileId"), 1L, 1);

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("FirstName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Gender")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<decimal?>("Height")
                        .HasColumnType("decimal(5,2)");

                    b.Property<string>("LastName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("UserID");

                    b.Property<decimal?>("Weight")
                        .HasColumnType("decimal(5,2)");

                    b.HasKey("ProfileId");

                    b.HasIndex("UserId");

                    b.ToTable("Profiles");
                });

            modelBuilder.Entity("Domain.Models.Recipe", b =>
                {
                    b.Property<int>("RecipeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("RecipeID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RecipeId"), 1L, 1);

                    b.Property<int?>("CookingTime")
                        .HasColumnType("int");

                    b.Property<string>("Instructions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PreparationTime")
                        .HasColumnType("int");

                    b.Property<string>("RecipeName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("RecipeId");

                    b.ToTable("Recipes");
                });

            modelBuilder.Entity("Domain.Models.RecipeIngredient", b =>
                {
                    b.Property<int>("RecipeIngredientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("RecipeIngredientID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RecipeIngredientId"), 1L, 1);

                    b.Property<int?>("FoodItemId")
                        .HasColumnType("int")
                        .HasColumnName("FoodItemID");

                    b.Property<decimal?>("Quantity")
                        .HasColumnType("decimal(5,2)");

                    b.Property<int?>("RecipeId")
                        .HasColumnType("int")
                        .HasColumnName("RecipeID");

                    b.HasKey("RecipeIngredientId");

                    b.HasIndex("FoodItemId");

                    b.HasIndex("RecipeId");

                    b.ToTable("RecipeIngredients");
                });

            modelBuilder.Entity("Domain.Models.Record", b =>
                {
                    b.Property<int>("RecordId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("RecordID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RecordId"), 1L, 1);

                    b.Property<int?>("ActivityId")
                        .HasColumnType("int")
                        .HasColumnName("ActivityID");

                    b.Property<DateTime?>("RecordDate")
                        .HasColumnType("date");

                    b.Property<int?>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("UserID");

                    b.HasKey("RecordId");

                    b.HasIndex("ActivityId");

                    b.HasIndex("UserId");

                    b.ToTable("Records");
                });

            modelBuilder.Entity("Domain.Models.ShoppingList", b =>
                {
                    b.Property<int>("ShoppingListId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ShoppingListID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShoppingListId"), 1L, 1);

                    b.Property<DateTime?>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("ListName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("UserID");

                    b.HasKey("ShoppingListId");

                    b.HasIndex("UserId");

                    b.ToTable("ShoppingLists");
                });

            modelBuilder.Entity("Domain.Models.ShoppingListItem", b =>
                {
                    b.Property<int>("ShoppingListItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ShoppingListItemID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShoppingListItemId"), 1L, 1);

                    b.Property<int?>("FoodItemId")
                        .HasColumnType("int")
                        .HasColumnName("FoodItemID");

                    b.Property<decimal?>("Quantity")
                        .HasColumnType("decimal(5,2)");

                    b.Property<int?>("ShoppingListId")
                        .HasColumnType("int")
                        .HasColumnName("ShoppingListID");

                    b.HasKey("ShoppingListItemId");

                    b.HasIndex("FoodItemId");

                    b.HasIndex("ShoppingListId");

                    b.ToTable("ShoppingListItems");
                });

            modelBuilder.Entity("Domain.Models.Tip", b =>
                {
                    b.Property<int>("TipId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("TipID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TipId"), 1L, 1);

                    b.Property<string>("Category")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TipText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("UserID");

                    b.HasKey("TipId");

                    b.HasIndex("UserId");

                    b.ToTable("Tips");
                });

            modelBuilder.Entity("Domain.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("UserID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<DateTime?>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Domain.Models.UserPreference", b =>
                {
                    b.Property<int>("UserPreferenceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("UserPreferenceID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserPreferenceId"), 1L, 1);

                    b.Property<string>("PreferenceName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PreferenceValue")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("UserID");

                    b.HasKey("UserPreferenceId");

                    b.HasIndex("UserId");

                    b.ToTable("UserPreferences");
                });

            modelBuilder.Entity("Domain.Models.Activity", b =>
                {
                    b.HasOne("Domain.Models.User", "User")
                        .WithMany("Activities")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK__Activitie__UserI__756D6ECB");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Models.FavoriteRecipe", b =>
                {
                    b.HasOne("Domain.Models.Recipe", "Recipe")
                        .WithMany("FavoriteRecipes")
                        .HasForeignKey("RecipeId")
                        .HasConstraintName("FK__FavoriteR__Recip__0880433F");

                    b.HasOne("Domain.Models.User", "User")
                        .WithMany("FavoriteRecipes")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK__FavoriteR__UserI__078C1F06");

                    b.Navigation("Recipe");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Models.FoodAllergen", b =>
                {
                    b.HasOne("Domain.Models.Allergen", "Allergen")
                        .WithMany("FoodAllergens")
                        .HasForeignKey("AllergenId")
                        .HasConstraintName("FK__FoodAller__Aller__1B9317B3");

                    b.HasOne("Domain.Models.FoodItem", "FoodItem")
                        .WithMany("FoodAllergens")
                        .HasForeignKey("FoodItemId")
                        .HasConstraintName("FK__FoodAller__FoodI__1A9EF37A");

                    b.Navigation("Allergen");

                    b.Navigation("FoodItem");
                });

            modelBuilder.Entity("Domain.Models.FoodItemCategory", b =>
                {
                    b.HasOne("Domain.Models.FoodCategory", "FoodCategory")
                        .WithMany("FoodItemCategories")
                        .HasForeignKey("FoodCategoryId")
                        .HasConstraintName("FK__FoodItemC__FoodC__04AFB25B");

                    b.HasOne("Domain.Models.FoodItem", "FoodItem")
                        .WithMany("FoodItemCategories")
                        .HasForeignKey("FoodItemId")
                        .HasConstraintName("FK__FoodItemC__FoodI__03BB8E22");

                    b.Navigation("FoodCategory");

                    b.Navigation("FoodItem");
                });

            modelBuilder.Entity("Domain.Models.Meal", b =>
                {
                    b.HasOne("Domain.Models.MealPlan", "MealPlan")
                        .WithMany("Meals")
                        .HasForeignKey("MealPlanId")
                        .HasConstraintName("FK__Meals__MealPlanI__69FBBC1F");

                    b.Navigation("MealPlan");
                });

            modelBuilder.Entity("Domain.Models.MealFoodItem", b =>
                {
                    b.HasOne("Domain.Models.FoodItem", "FoodItem")
                        .WithMany("MealFoodItems")
                        .HasForeignKey("FoodItemId")
                        .HasConstraintName("FK__MealFoodI__FoodI__6FB49575");

                    b.HasOne("Domain.Models.Meal", "Meal")
                        .WithMany("MealFoodItems")
                        .HasForeignKey("MealId")
                        .HasConstraintName("FK__MealFoodI__MealI__6EC0713C");

                    b.Navigation("FoodItem");

                    b.Navigation("Meal");
                });

            modelBuilder.Entity("Domain.Models.MealPlan", b =>
                {
                    b.HasOne("Domain.Models.User", "User")
                        .WithMany("MealPlans")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK__MealPlans__UserI__662B2B3B");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Models.NutritionalGoal", b =>
                {
                    b.HasOne("Domain.Models.User", "User")
                        .WithMany("NutritionalGoals")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK__Nutrition__UserI__72910220");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Models.Profile", b =>
                {
                    b.HasOne("Domain.Models.User", "User")
                        .WithMany("Profiles")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK__Profiles__UserID__634EBE90");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Models.RecipeIngredient", b =>
                {
                    b.HasOne("Domain.Models.FoodItem", "FoodItem")
                        .WithMany("RecipeIngredients")
                        .HasForeignKey("FoodItemId")
                        .HasConstraintName("FK__RecipeIng__FoodI__7EF6D905");

                    b.HasOne("Domain.Models.Recipe", "Recipe")
                        .WithMany("RecipeIngredients")
                        .HasForeignKey("RecipeId")
                        .HasConstraintName("FK__RecipeIng__Recip__7E02B4CC");

                    b.Navigation("FoodItem");

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("Domain.Models.Record", b =>
                {
                    b.HasOne("Domain.Models.Activity", "Activity")
                        .WithMany("Records")
                        .HasForeignKey("ActivityId")
                        .HasConstraintName("FK__Records__Activit__793DFFAF");

                    b.HasOne("Domain.Models.User", "User")
                        .WithMany("Records")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK__Records__UserID__7849DB76");

                    b.Navigation("Activity");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Models.ShoppingList", b =>
                {
                    b.HasOne("Domain.Models.User", "User")
                        .WithMany("ShoppingLists")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK__ShoppingL__UserI__0C50D423");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Models.ShoppingListItem", b =>
                {
                    b.HasOne("Domain.Models.FoodItem", "FoodItem")
                        .WithMany("ShoppingListItems")
                        .HasForeignKey("FoodItemId")
                        .HasConstraintName("FK__ShoppingL__FoodI__10216507");

                    b.HasOne("Domain.Models.ShoppingList", "ShoppingList")
                        .WithMany("ShoppingListItems")
                        .HasForeignKey("ShoppingListId")
                        .HasConstraintName("FK__ShoppingL__Shopp__0F2D40CE");

                    b.Navigation("FoodItem");

                    b.Navigation("ShoppingList");
                });

            modelBuilder.Entity("Domain.Models.Tip", b =>
                {
                    b.HasOne("Domain.Models.User", "User")
                        .WithMany("Tips")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK__Tips__UserID__12FDD1B2");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Models.UserPreference", b =>
                {
                    b.HasOne("Domain.Models.User", "User")
                        .WithMany("UserPreferences")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK__UserPrefe__UserI__15DA3E5D");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Models.Activity", b =>
                {
                    b.Navigation("Records");
                });

            modelBuilder.Entity("Domain.Models.Allergen", b =>
                {
                    b.Navigation("FoodAllergens");
                });

            modelBuilder.Entity("Domain.Models.FoodCategory", b =>
                {
                    b.Navigation("FoodItemCategories");
                });

            modelBuilder.Entity("Domain.Models.FoodItem", b =>
                {
                    b.Navigation("FoodAllergens");

                    b.Navigation("FoodItemCategories");

                    b.Navigation("MealFoodItems");

                    b.Navigation("RecipeIngredients");

                    b.Navigation("ShoppingListItems");
                });

            modelBuilder.Entity("Domain.Models.Meal", b =>
                {
                    b.Navigation("MealFoodItems");
                });

            modelBuilder.Entity("Domain.Models.MealPlan", b =>
                {
                    b.Navigation("Meals");
                });

            modelBuilder.Entity("Domain.Models.Recipe", b =>
                {
                    b.Navigation("FavoriteRecipes");

                    b.Navigation("RecipeIngredients");
                });

            modelBuilder.Entity("Domain.Models.ShoppingList", b =>
                {
                    b.Navigation("ShoppingListItems");
                });

            modelBuilder.Entity("Domain.Models.User", b =>
                {
                    b.Navigation("Activities");

                    b.Navigation("FavoriteRecipes");

                    b.Navigation("MealPlans");

                    b.Navigation("NutritionalGoals");

                    b.Navigation("Profiles");

                    b.Navigation("Records");

                    b.Navigation("ShoppingLists");

                    b.Navigation("Tips");

                    b.Navigation("UserPreferences");
                });
#pragma warning restore 612, 618
        }
    }
}
