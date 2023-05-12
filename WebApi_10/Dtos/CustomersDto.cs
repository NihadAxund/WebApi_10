using WebApi_10.Entities;

namespace WebApi_10.Dtos
{
    public class CustomersDto
    {
        private int id {get;set;}
        public string FullName { get; set; }
        public CustomersDto() { }

        public CustomersDto(Customers customers) {
            FullName = customers.Name + " " + customers.Surname;
            id = customers.Id;
        }


        public override string ToString() => $"Id:{id}\nFullName{FullName}";

    }
}
