using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP
{
    public class Month
    {

        public Month()
        {

        }
        // Остаток
        public decimal Remainder { get; set; }

        public decimal Spending { get; set; }

        // Траты на супермаркеты
        public decimal SupermarketExpenses { get; set; }

        // Траты на рестораны
        public decimal RestaurantExpenses { get; set; }

        // Траты на аптеки
        public decimal PharmacyExpenses { get; set; }

        // Траты на переводы
        public decimal TransferExpenses { get; set; }

        // Траты на электронику
        public decimal ElectronicsExpenses { get; set; }

        // Траты на транспорт
        public decimal TransportExpenses { get; set; }

        // История трат
        public List<string> ExpensesHistory { get; set; } = new List<string>();

        // Методы для добавления к каждому
        public void AddToRemainder(decimal value)
        {
            Remainder += value;
        }

        public void AddSpending(decimal value)
        {
            Spending += value;
        }

        public void AddToSupermarketExpenses(decimal value)
        {
            SupermarketExpenses += value;
        }

        public void AddToRestaurantExpenses(decimal value)
        {
            RestaurantExpenses += value;
        }

        public void AddToPharmacyExpenses(decimal value)
        {
            PharmacyExpenses += value;
        }

        public void AddToTransferExpenses(decimal value)
        {
            TransferExpenses += value;
        }

        public void AddToElectronicsExpenses(decimal value)
        {
            ElectronicsExpenses += value;
        }

        public void AddToTransportExpenses(decimal value)
        {
            TransportExpenses += value;
        }

        public void AddToExpensesHistory(string expense)
        {
            ExpensesHistory.Add(expense);
        }

        public void Check(ListBox listBox1)
        {
            foreach (var item in ExpensesHistory)
            {
                listBox1.Items.Add(item);
            }
        }   
            


    }


}
