using MongoDB.Bson;

namespace ExpensesCalculatorBackend.Models
{
    public class CategoryModel
    {
        public ObjectId Id { get; set; }
        public string name { get; set; }

    }
}
