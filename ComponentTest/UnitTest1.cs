using Bunit;
using CDNApplication.TCComponents;
using CDNApplication.TestHelper;
using System;
using Xunit;
using CDNApplication.Pages;

// to test TCInputText, we had to place it inside <EditForm> tag, EditForm also requires a model.
//so, I had to build a temporary
//Component called "TestHelp" inside CDN application project .
// Also inside TCInputText, I had to add @oninput=@ValueEntered/ event handler and the method
// So, we need to discuss the value in testing TC components.

//
// We should only test teh components that we duild ourselves not the ones from ESDC.




namespace ComponentTest
{
    public class UnitTest1
    {
        // in this test we render TCInputText component inside TestHelper. 
        // and we enter a string into the input element and fetch the value from the input element then
        // compare the two values.

        [Fact]
        public void TCInputTextTest()
        {

            string valueEntered = "Hello Razor";
            string valueFetchedFromElement = "";

            var context = new TestContext();

            var markup = context.RenderComponent<TestHelper>();

            var inputElement = markup.Find("input");

            var markupOfInput= inputElement.ToMarkup();

            inputElement.Input(valueEntered);

            var someChange = markup.GetChangesSinceFirstRender();


            valueFetchedFromElement = inputElement.Attributes["value"].Value;

            Assert.Equal(valueFetchedFromElement, valueEntered);


        }
    }


}
