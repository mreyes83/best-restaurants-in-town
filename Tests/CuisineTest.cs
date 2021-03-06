using Xunit;
using System.Collections.Generic;
using System;
using System.Data;
using System.Data.SqlClient;

namespace BestRestaurantsInTown
{
    public class CuisineTest : IDisposable
    {
        public CuisineTest()
        {
            DBConfiguration.ConnectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=best_restaurants_test;Integrated Security=SSPI;";
        }
        public void Dispose()
        {
            Cuisine.DeleteAll();
        }

        [Fact]
        public void Test_DatbaseEmptyToStart()
        {
            //Arrange, Act
            int result = Cuisine.GetAll().Count;
            //Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void Cuisine_AreEqual()
        {
          //Arrange, Act
          Cuisine firstCuisine = new Cuisine("Japanese");
          Cuisine secondCuisine = new Cuisine("Japanese");
          //Assert
          Assert.Equal(firstCuisine, secondCuisine);
        }

        [Fact]
        public void Cuisine_SavesToDatabase()
        {
          //Arrange
          Cuisine testCuisine = new Cuisine("Japanese");
          //Act
          testCuisine.Save();
          Cuisine savedCuisine = Cuisine.GetAll()[0];
          //Assert
          Assert.Equal(testCuisine, savedCuisine);
        }

        [Fact]
        public void Cuisine_SavesWithId()
        {
          //Arrange
          Cuisine testCuisine = new Cuisine("Japanese");
          //Act
          testCuisine.Save();
          Cuisine savedCuisine = Cuisine.GetAll()[0];
          int result = savedCuisine.GetId();
          int expectedResult = testCuisine.GetId();
          //Assert
          Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Cuisine_FindReturnsCorrectCuisine()
        {
          //Arrange
          Cuisine testCuisine = new Cuisine("Japanese");
          //Act
          testCuisine.Save();
          Cuisine foundCuisine = Cuisine.Find(testCuisine.GetId());
          //Assert
          Assert.Equal(testCuisine, foundCuisine);
        }

        [Fact]
        public void Cuisine_UpdateCuisineName()
        {
          //Arrange
          Cuisine testCuisine = new Cuisine("Japanese");
          string expectedResult = "Mexican";
          testCuisine.Save();
          //Act
          testCuisine.Update("Mexican");
          string result = testCuisine.GetCuisineType();
          //Assert
          Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Cuisine_GetsAllRestaurantsInCuisine()
        {
          //Arrange
          Cuisine testCuisine = new Cuisine("Japanese");
          testCuisine.Save();
          //Act
          Restaurant firstRestaurant = new Restaurant("Yama", testCuisine.GetId(), "unforgettable japanese dining experience", "926 NW 10th Avenue, Portland, OR 97209", "503.841.5463", "none@none.com");
          firstRestaurant.Save();

          List<Restaurant> expectedList = new List<Restaurant> {firstRestaurant};
          List<Restaurant> testList = testCuisine.GetRestaurants();
          //Assert
          Assert.Equal(expectedList, testList);
        }
    }
}
