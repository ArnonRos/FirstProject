using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{ 
    public class DeliveryResult
    {
        public bool isSuccess { get;  }
        public string Message { get; }
        private DeliveryResult(bool isSuccess, string message)
        {
            isSuccess = isSuccess;
            Message = message;
        }


        public static DeliveryResult Success(string message = "Operation completed successfully.")
        {
            return new DeliveryResult(true, message);
        }
        public static DeliveryResult Failure(string errorMessage = "Operation completed unsuccessfully")
        {
            return new DeliveryResult(false, errorMessage);
        }
    } 
}





