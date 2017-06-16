using System.Drawing;
using System.Web.UI.WebControls;

namespace Chapter25.PushDownDependency_1_2
{
    public class CustomerValidator
    {
        private TextBox UsernameTextbox { get; set; }

        public void Validate(Customer customer)
        {
            if (string.IsNullOrWhiteSpace(customer.Username))
            {
                HightLightUsername();
            }
        }

        public void HightLightUsername()
        {
            UsernameTextbox.ForeColor = Color.Red;
        }
    }

    public class Customer
    {
        public string Username { get; set; }
    }

    public class CustomerValidatorTests
    {
        public void Validate_XXX_XXX()
        {
            // Arrange
            var customer = new Customer();
            var validator = new CustomerValidator();

            // Act
            validator.Validate(customer); // Error

            // ...
        }
    }
}

namespace Chapter25.PushDownDependency_3_4_5
{
    public class Customer
    {
        public string Username { get; set; }
    }

    public class TextboxCustomerValidator : CustomerValidator
    {
        private TextBox UsernameTextbox { get; set; }

        protected override void HightLightUsername()
        {
            UsernameTextbox.ForeColor = Color.Red;
        }
    }

    public abstract class CustomerValidator
    {
        public void Validate(Customer customer)
        {
            if (string.IsNullOrWhiteSpace(customer.Username))
            {
                HightLightUsername();
            }
        }

        protected abstract void HightLightUsername();
    }

    public class CustomerValidatorMock : CustomerValidator
    {
        protected override void HightLightUsername() { }
    }

    public class CustomerValidatorTests
    {
        public void Validate_XXX_XXX()
        {
            // Arrange
            var customer = new Customer();
            var validator = new CustomerValidatorMock();

            // Act
            validator.Validate(customer);

            // ...
        }
    }
}
