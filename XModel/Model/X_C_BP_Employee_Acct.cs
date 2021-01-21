namespace VAdvantage.Model
{

/** Generated Model - DO NOT CHANGE */
using System;
using System.Text;
using VAdvantage.DataBase;
using VAdvantage.Common;
using VAdvantage.Classes;
using VAdvantage.Process;
using VAdvantage.Model;
using VAdvantage.Utility;
using System.Data;
/** Generated Model for C_BP_Employee_Acct
 *  @author Jagmohan Bhatt (generated) 
 *  @version Vienna Framework 1.1.1 - $Id$ */
public class X_C_BP_Employee_Acct : PO
{
public X_C_BP_Employee_Acct (Context ctx, int C_BP_Employee_Acct_ID, Trx trxName) : base (ctx, C_BP_Employee_Acct_ID, trxName)
{
/** if (C_BP_Employee_Acct_ID == 0)
{
SetC_AcctSchema_ID (0);
SetC_BPartner_ID (0);
SetE_Expense_Acct (0);
SetE_Prepayment_Acct (0);
}
 */
}
public X_C_BP_Employee_Acct (Ctx ctx, int C_BP_Employee_Acct_ID, Trx trxName) : base (ctx, C_BP_Employee_Acct_ID, trxName)
{
/** if (C_BP_Employee_Acct_ID == 0)
{
SetC_AcctSchema_ID (0);
SetC_BPartner_ID (0);
SetE_Expense_Acct (0);
SetE_Prepayment_Acct (0);
}
 */
}
/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_C_BP_Employee_Acct (Context ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName)
{
}
/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_C_BP_Employee_Acct (Ctx ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName)
{
}
/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_C_BP_Employee_Acct (Ctx ctx, IDataReader dr, Trx trxName) : base(ctx, dr, trxName)
{
}
/** Static Constructor 
 Set Table ID By Table Name
 added by ->Harwinder */
static X_C_BP_Employee_Acct()
{
 Table_ID = Get_Table_ID(Table_Name);
 model = new KeyNamePair(Table_ID,Table_Name);
}
/** Serial Version No */
//static long serialVersionUID 27562514370024L;
/** Last Updated Timestamp 7/29/2010 1:07:33 PM */
public static long updatedMS = 1280389053235L;
/** VAF_TableView_ID=184 */
public static int Table_ID;
 // =184;

/** TableName=C_BP_Employee_Acct */
public static String Table_Name="C_BP_Employee_Acct";

protected static KeyNamePair model;
protected Decimal accessLevel = new Decimal(3);
/** AccessLevel
@return 3 - Client - Org 
*/
protected override int Get_AccessLevel()
{
return Convert.ToInt32(accessLevel.ToString());
}
/** Load Meta Data
@param ctx context
@return PO Info
*/
protected override POInfo InitPO (Ctx ctx)
{
POInfo poi = POInfo.GetPOInfo (ctx, Table_ID);
return poi;
}
/** Load Meta Data
@param ctx context
@return PO Info
*/
protected override POInfo InitPO(Context ctx)
{
POInfo poi = POInfo.GetPOInfo (ctx, Table_ID);
return poi;
}
/** Info
@return info
*/
public override String ToString()
{
StringBuilder sb = new StringBuilder ("X_C_BP_Employee_Acct[").Append(Get_ID()).Append("]");
return sb.ToString();
}
/** Set Accounting Schema.
@param C_AcctSchema_ID Rules for accounting */
public void SetC_AcctSchema_ID (int C_AcctSchema_ID)
{
if (C_AcctSchema_ID < 1) throw new ArgumentException ("C_AcctSchema_ID is mandatory.");
Set_ValueNoCheck ("C_AcctSchema_ID", C_AcctSchema_ID);
}
/** Get Accounting Schema.
@return Rules for accounting */
public int GetC_AcctSchema_ID() 
{
Object ii = Get_Value("C_AcctSchema_ID");
if (ii == null) return 0;
return Convert.ToInt32(ii);
}
/** Get Record ID/ColumnName
@return ID/ColumnName pair */
public KeyNamePair GetKeyNamePair() 
{
return new KeyNamePair(Get_ID(), GetC_AcctSchema_ID().ToString());
}
/** Set Business Partner.
@param C_BPartner_ID Identifies a Business Partner */
public void SetC_BPartner_ID (int C_BPartner_ID)
{
if (C_BPartner_ID < 1) throw new ArgumentException ("C_BPartner_ID is mandatory.");
Set_ValueNoCheck ("C_BPartner_ID", C_BPartner_ID);
}
/** Get Business Partner.
@return Identifies a Business Partner */
public int GetC_BPartner_ID() 
{
Object ii = Get_Value("C_BPartner_ID");
if (ii == null) return 0;
return Convert.ToInt32(ii);
}
/** Set Employee Expense.
@param E_Expense_Acct Account for Employee Expenses */
public void SetE_Expense_Acct (int E_Expense_Acct)
{
Set_Value ("E_Expense_Acct", E_Expense_Acct);
}
/** Get Employee Expense.
@return Account for Employee Expenses */
public int GetE_Expense_Acct() 
{
Object ii = Get_Value("E_Expense_Acct");
if (ii == null) return 0;
return Convert.ToInt32(ii);
}
/** Set Employee Prepayment.
@param E_Prepayment_Acct Account for Employee Expense Prepayments */
public void SetE_Prepayment_Acct (int E_Prepayment_Acct)
{
Set_Value ("E_Prepayment_Acct", E_Prepayment_Acct);
}
/** Get Employee Prepayment.
@return Account for Employee Expense Prepayments */
public int GetE_Prepayment_Acct() 
{
Object ii = Get_Value("E_Prepayment_Acct");
if (ii == null) return 0;
return Convert.ToInt32(ii);
}
}

}