
namespace ModelsDemo02
{
    public class LogHelper<T> where T: BaseClass
    {
        public static T SetCreateParams(T obj,string employee)
        {
            obj.CreatedBy = employee;
            obj.CreatedAt = DateTime.Now;
            return obj;
        }
        public static T SetUpdateParams(T obj,string employee)
        {
            obj.UpdatedBy = employee;
            obj.UpdatedAt = DateTime.Now;
            return obj;
        }
    }
}
