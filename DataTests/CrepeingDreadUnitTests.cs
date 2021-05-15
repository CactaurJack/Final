using System;
using System.Collections.Generic;
using Xunit;
using Data;

namespace DataTests
{
    public class CrepeingDreadUnitTests
    {
        [Fact]
        public void NameShouldBeCorrectForBunchOfCrepeingDread()
        {

        }

        [Fact]
        public void NameShouldBeCorrectForVeganCrepeingDread()
        {

        }

        [Fact]
        public void NameShouldBeCorrectForSweetCrepeingDread()
        {

        }

        [Theory]
        [InlineData(true, true, true, false, false, false, false, false, false, 1.00)]
        public void PriceShouldBeCorrectForBunchOfCrepeingDread(bool ham, bool cheese, bool eggs, bool spinach, bool mushroom, bool leeks, bool berries, bool whippedCream, bool hazelnutSpread, decimal price)
        {

        }

        [Theory]
        [InlineData(false, false, false, true, true, true, false, false, false, 1.00)]
        public void PriceShouldBeCorrectForVeganCrepeingDread(bool ham, bool cheese, bool eggs, bool spinach, bool mushroom, bool leeks, bool berries, bool whippedCream, bool hazelnutSpread, decimal price)
        {

        }

        [Theory]
        [InlineData(false, false, false, false, false, false, true, true, true, 1.00)]
        public void PriceShouldBeCorrectForSweetCrepeingDread(bool ham, bool cheese, bool eggs, bool spinach, bool mushroom, bool leeks, bool berries, bool whippedCream, bool hazelnutSpread, decimal price)
        {

        }


        [Theory]
        [InlineData(true, true, true, false, false, false, false, false, false, 612)]
        public void CaloriesShouldBeCorrectForBunchOfCrepeingDread(bool ham, bool cheese, bool eggs, bool spinach, bool mushroom, bool leeks, bool berries, bool whippedCream, bool hazelnutSpread, uint calories)
        {

        }

        [Theory]
        [InlineData(false, false, false, true, true, true, false, false, false, 121)]
        public void CaloriesShouldBeCorrectForVeganCrepeingDread(bool ham, bool cheese, bool eggs, bool spinach, bool mushroom, bool leeks, bool berries, bool whippedCream, bool hazelnutSpread, uint calories)
        {

        }

        [Theory]
        [InlineData(false, false, false, false, false, false, true, true, true, 344)]
        public void CaloriesShouldBeCorrectForSweetCrepeingDread(bool ham, bool cheese, bool eggs, bool spinach, bool mushroom, bool leeks, bool berries, bool whippedCream, bool hazelnutSpread, uint calories)
        {

        }

        [Theory]
        [InlineData(true, true, true, false, false, false, false, false, false, new string[] { })]
        [InlineData(true, true, true, false, false, false, false, false, true, new string[] { "Add Hazelnut Spread" })]
        public void SpecialInstructionsShouldBeCorrectForBunchOfCrepeingDread(bool ham, bool cheese, bool eggs, bool spinach, bool mushroom, bool leeks, bool berries, bool whippedCream, bool hazelnutSpread, IEnumerable<string> expectedInstructions)
        {

        }

        [Theory]
        [InlineData(false, false, false, true, true, true, false, false, false, new string[] { })]
        public void SpecialInstructionsShouldBeCorrectForVeganCrepeingDread(bool ham, bool cheese, bool eggs, bool spinach, bool mushroom, bool leeks, bool berries, bool whippedCream, bool hazelnutSpread, IEnumerable<string> expectedInstructions)
        {

        }

        [Theory]
        [InlineData(false, false, false, false, false, false, true, true, true, new string[] { })]
        public void SpecialInstructionsShouldBeCorrectForSweetCrepeingDread(bool ham, bool cheese, bool eggs, bool spinach, bool mushroom, bool leeks, bool berries, bool whippedCream, bool hazelnutSpread, IEnumerable<string> expectedInstructions)
        {

        }

        [Fact]
        public void BrunchOfCrepeingDreadShouldHaveWholeWheatFlourByDefault()
        {

        }

        [Fact]
        public void VeganCrepeingDreadShouldHaveBuckwheatFlourByDefault()
        {

        }

        [Fact]
        public void SweetCrepeingDreadShouldHaveWhiteFlourByDefault()
        {

        }

        [Theory]
        public void ShouldBeAbleToSetFlourForBrunchOfCrepeingDread(Flour flour)
        {

        }

        [Theory]
        public void ShouldBeAbleToSetFlourForVeganCrepeingDread(Flour flour)
        {

        }

        [Theory]
        public void ShouldBeAbleToSetFlourForSweetCrepeingDread(Flour flour)
        {

        }

        [Fact]
        public void BrunchOfCrepeingDreadShouldHaveDefaultIngredients()
        {

        }

        [Fact]
        public void BrunchOfCrepeingDreadShouldNotHaveOtherIngredients()
        {

        }

        [Fact]
        public void VeganCrepeingDreadShouldHaveDefaultIngredients()
        {

        }

        [Fact]
        public void VeganCrepeingDreadShouldNotHaveOtherIngredients()
        {

        }

        [Fact]
        public void SweetCrepeingDreadShouldHaveDefaultIngredients()
        {

        }

        [Fact]
        public void SweetCrepeingDreadShouldNotHaveOtherIngredients()
        {

        }

        [Fact]
        public void ShouldBeAbleToSetHamForBrunchOfCrepeingDread()
        {

        }

        [Fact]
        public void ShouldBeAbleToSetEggForBrunchOfCrepeingDread()
        {

        }

        [Fact]
        public void ShouldBeAbleToSetCheeseForBrunchOfCrepeingDread()
        {

        }

        [Fact]
        public void ShouldBeAbleToSetSpinachForBrunchOfCrepeingDread()
        {

        }

        [Fact]
        public void ShouldBeAbleToSetMushroomsForBrunchOfCrepeingDread()
        {

        }

        [Fact]
        public void ShouldBeAbleToSetLeeksForBrunchOfCrepeingDread()
        {

        }

        [Fact]
        public void ShouldBeAbleToSetHazelnutSpreadForBrunchOfCrepeingDread()
        {

        }

        [Fact]
        public void ShouldBeAbleToSetBerriesForBrunchOfCrepeingDread()
        {

        }

        [Fact]
        public void ShouldBeAbleToSetWhippedCreamForBrunchOfCrepeingDread()
        {

        }

        [Fact]
        public void ShouldBeAbleToSetHamForVeganCrepeingDread()
        {

        }

        [Fact]
        public void ShouldBeAbleToSetEggForVeganCrepeingDread()
        {

        }

        [Fact]
        public void ShouldBeAbleToSetCheeseForVeganCrepeingDread()
        {

        }

        [Fact]
        public void ShouldBeAbleToSetSpinachForVeganCrepeingDread()
        {

        }

        [Fact]
        public void ShouldBeAbleToSetMushroomsForVeganCrepeingDread()
        {

        }

        [Fact]
        public void ShouldBeAbleToSetLeeksForVeganCrepeingDread()
        {

        }

        [Fact]
        public void ShouldBeAbleToSetHazelnutSpreadForVeganCrepeingDread()
        {

        }

        [Fact]
        public void ShouldBeAbleToSetBerriesForVeganCrepeingDread()
        {

        }

        [Fact]
        public void ShouldBeAbleToSetWhippedCreamForVeganCrepeingDread()
        {

        }

        [Fact]
        public void ShouldBeAbleToSetHamForSweetCrepeingDread()
        {

        }

        [Fact]
        public void ShouldBeAbleToSetEggForSweetCrepeingDread()
        {

        }

        [Fact]
        public void ShouldBeAbleToSetCheeseForSweetCrepeingDread()
        {

        }

        [Fact]
        public void ShouldBeAbleToSetSpinachForSweetCrepeingDread()
        {

        }

        [Fact]
        public void ShouldBeAbleToSetMushroomsForSweetCrepeingDread()
        {

        }

        [Fact]
        public void ShouldBeAbleToSetLeeksForSweetCrepeingDread()
        {

        }

        [Fact]
        public void ShouldBeAbleToSetHazelnutSpreadForSweetCrepeingDread()
        {

        }

        [Fact]
        public void ShouldBeAbleToSetBerriesForSweetCrepeingDread()
        {

        }

        [Fact]
        public void ShouldBeAbleToSetWhippedCreamForSweetCrepeingDread()
        {

        }

        [Fact]
        public void BrunchOfCrepeingDreadShouldInheritFromCrepeingDread()
        {

        }

        [Fact]
        public void VeganCrepeingDreadShouldInheritFromCrepeingDread()
        {

        }

        [Fact]
        public void SweetCrepeingDreadShouldInheritFromCrepeingDread()
        {

        }

        [Fact]
        public void BrunchOfCrepeingDreadShouldImplementIMenuItem()
        {

        }

        [Fact]
        public void VeganCrepeingDreadShouldImplementIMenuItem()
        {

        }

        [Fact]
        public void SweetCrepeingDreadShouldImplementIMenuItem()
        {

        }

    }
}
