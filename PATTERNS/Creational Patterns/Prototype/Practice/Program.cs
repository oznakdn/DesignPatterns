// See https://aka.ms/new-console-template for more information
using Practice;

Console.WriteLine("Hello, World!");

Account normalDefaultAccount = new("TR2435454656", 1000, 1000, new Customer("Mehmet"), true, true, true);


// Can not transfer account

Account noTransferAccount =(Account) normalDefaultAccount.Clone();
noTransferAccount.SetBalance(20);
noTransferAccount.SetCredit(0);
noTransferAccount.SetToPayment(true);
noTransferAccount.SetToWithdraw(false);
noTransferAccount.SetToTranser(false);

var _balance = noTransferAccount.GetBalance();
var _credit = noTransferAccount.GetCredit();
var _toPayment = noTransferAccount.GetToPayment();
var _toTransfer = noTransferAccount.GetToTransfer();
var _toWithdraw = noTransferAccount.GetToWithdraw();

Console.WriteLine(noTransferAccount.ToString());
Console.WriteLine($"Balance: {_balance} Credit: {_credit} Can to Payment: {_toPayment} Can to Transfer: {_toTransfer} Can to Withdraw: {_toWithdraw}");


/* Output
Mehmet TR2435454656 20 0
Balance: 20 Credit: 0 Can to Payment: True Can to Transfer: False Can to Withdraw: False
*/

// Frozen account

Account frozenAccount = (Account)normalDefaultAccount.Clone();
frozenAccount.SetBalance(0);
frozenAccount.SetCredit(-1000);
frozenAccount.SetToPayment(false);
frozenAccount.SetToTranser(false);
frozenAccount.SetToWithdraw(false);

var balance = frozenAccount.GetBalance();
var credit = frozenAccount.GetCredit();
var toPayment = frozenAccount.GetToPayment();
var toTransfer = frozenAccount.GetToTransfer();
var toWithdraw = frozenAccount.GetToWithdraw();

Console.WriteLine(frozenAccount.ToString());
Console.WriteLine($"Balance: {balance} Credit: {credit} Can to Payment: {toPayment} Can to Transfer: {toTransfer} Can to Withdraw: {toWithdraw}");

/* Output
Mehmet TR2435454656 0 -1000
Balance: 0 Credit: -1000 Can to Payment: False Can to Transfer: False Can to Withdraw: False
*/
