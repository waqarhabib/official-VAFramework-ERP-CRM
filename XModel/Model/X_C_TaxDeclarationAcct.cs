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
/** Generated Model for VAB_TaxComputationAcct
 *  @author Jagmohan Bhatt (generated) 
 *  @version Vienna Framework 1.1.1 - $Id$ */
public class X_VAB_TaxComputationAcct : PO
{
public X_VAB_TaxComputationAcct (Context ctx, int VAB_TaxComputationAcct_ID, Trx trxName) : base (ctx, VAB_TaxComputationAcct_ID, trxName)
{
/** if (VAB_TaxComputationAcct_ID == 0)
{
SetVAB_AccountBook_ID (0);
SetVAB_TaxComputationAcct_ID (0);
SetVAB_TaxRateComputation_ID (0);
SetActual_Acct_Detail_ID (0);
}
 */
}
public X_VAB_TaxComputationAcct (Ctx ctx, int VAB_TaxComputationAcct_ID, Trx trxName) : base (ctx, VAB_TaxComputationAcct_ID, trxName)
{
/** if (VAB_TaxComputationAcct_ID == 0)
{
SetVAB_AccountBook_ID (0);
SetVAB_TaxComputationAcct_ID (0);
SetVAB_TaxRateComputation_ID (0);
SetActual_Acct_Detail_ID (0);
}
 */
}
/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_VAB_TaxComputationAcct (Context ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName)
{
}
/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_VAB_TaxComputationAcct (Ctx ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName)
{
}
/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_VAB_TaxComputationAcct (Ctx ctx, IDataReader dr, Trx trxName) : base(ctx, dr, trxName)
{
}
/** Static Constructor 
 Set Table ID By Table Name
 added by ->Harwinder */
static X_VAB_TaxComputationAcct()
{
 Table_ID = Get_Table_ID(Table_Name);
 model = new KeyNamePair(Table_ID,Table_Name);
}
/** Serial Version No */
//static long serialVersionUID 27562514375463L;
/** Last Updated Timestamp 7/29/2010 1:07:38 PM */
public static long updatedMS = 1280389058674L;
/** VAF_TableView_ID=820 */
public static int Table_ID;
 // =820;

/** TableName=VAB_TaxComputationAcct */
public static String Table_Name="VAB_TaxComputationAcct";

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
StringBuilder sb = new StringBuilder ("X_VAB_TaxComputationAcct[").Append(Get_ID()).Append("]");
return sb.ToString();
}

/** Account_ID VAF_Control_Ref_ID=331 */
public static int ACCOUNT_ID_VAF_Control_Ref_ID=331;
/** Set Account.
@param Account_ID Account used */
public void SetAccount_ID (int Account_ID)
{
throw new ArgumentException ("Account_ID Is virtual column");
}
/** Get Account.
@return Account used */
public int GetAccount_ID() 
{
Object ii = Get_Value("Account_ID");
if (ii == null) return 0;
return Convert.ToInt32(ii);
}
/** Set Accounted Credit.
@param AmtAcctCr Accounted Credit Amount */
public void SetAmtAcctCr (Decimal? AmtAcctCr)
{
throw new ArgumentException ("AmtAcctCr Is virtual column");
}
/** Get Accounted Credit.
@return Accounted Credit Amount */
public Decimal GetAmtAcctCr() 
{
Object bd =Get_Value("AmtAcctCr");
if (bd == null) return Env.ZERO;
return  Convert.ToDecimal(bd);
}
/** Set Accounted Debit.
@param AmtAcctDr Accounted Debit Amount */
public void SetAmtAcctDr (Decimal? AmtAcctDr)
{
throw new ArgumentException ("AmtAcctDr Is virtual column");
}
/** Get Accounted Debit.
@return Accounted Debit Amount */
public Decimal GetAmtAcctDr() 
{
Object bd =Get_Value("AmtAcctDr");
if (bd == null) return Env.ZERO;
return  Convert.ToDecimal(bd);
}
/** Set Source Credit.
@param AmtSourceCr Source Credit Amount */
public void SetAmtSourceCr (Decimal? AmtSourceCr)
{
throw new ArgumentException ("AmtSourceCr Is virtual column");
}
/** Get Source Credit.
@return Source Credit Amount */
public Decimal GetAmtSourceCr() 
{
Object bd =Get_Value("AmtSourceCr");
if (bd == null) return Env.ZERO;
return  Convert.ToDecimal(bd);
}
/** Set Source Debit.
@param AmtSourceDr Source Debit Amount */
public void SetAmtSourceDr (Decimal? AmtSourceDr)
{
throw new ArgumentException ("AmtSourceDr Is virtual column");
}
/** Get Source Debit.
@return Source Debit Amount */
public Decimal GetAmtSourceDr() 
{
Object bd =Get_Value("AmtSourceDr");
if (bd == null) return Env.ZERO;
return  Convert.ToDecimal(bd);
}
/** Set Accounting Schema.
@param VAB_AccountBook_ID Rules for accounting */
public void SetVAB_AccountBook_ID (int VAB_AccountBook_ID)
{
if (VAB_AccountBook_ID < 1) throw new ArgumentException ("VAB_AccountBook_ID is mandatory.");
Set_ValueNoCheck ("VAB_AccountBook_ID", VAB_AccountBook_ID);
}
/** Get Accounting Schema.
@return Rules for accounting */
public int GetVAB_AccountBook_ID() 
{
Object ii = Get_Value("VAB_AccountBook_ID");
if (ii == null) return 0;
return Convert.ToInt32(ii);
}
/** Set Business Partner.
@param VAB_BusinessPartner_ID Identifies a Business Partner */
public void SetVAB_BusinessPartner_ID (int VAB_BusinessPartner_ID)
{
throw new ArgumentException ("VAB_BusinessPartner_ID Is virtual column");
}
/** Get Business Partner.
@return Identifies a Business Partner */
public int GetVAB_BusinessPartner_ID() 
{
Object ii = Get_Value("VAB_BusinessPartner_ID");
if (ii == null) return 0;
return Convert.ToInt32(ii);
}
/** Set Currency.
@param VAB_Currency_ID The Currency for this record */
public void SetVAB_Currency_ID (int VAB_Currency_ID)
{
throw new ArgumentException ("VAB_Currency_ID Is virtual column");
}
/** Get Currency.
@return The Currency for this record */
public int GetVAB_Currency_ID() 
{
Object ii = Get_Value("VAB_Currency_ID");
if (ii == null) return 0;
return Convert.ToInt32(ii);
}
/** Set Tax Declaration Accounting.
@param VAB_TaxComputationAcct_ID Tax Accounting Reconciliation */
public void SetVAB_TaxComputationAcct_ID (int VAB_TaxComputationAcct_ID)
{
if (VAB_TaxComputationAcct_ID < 1) throw new ArgumentException ("VAB_TaxComputationAcct_ID is mandatory.");
Set_ValueNoCheck ("VAB_TaxComputationAcct_ID", VAB_TaxComputationAcct_ID);
}
/** Get Tax Declaration Accounting.
@return Tax Accounting Reconciliation */
public int GetVAB_TaxComputationAcct_ID() 
{
Object ii = Get_Value("VAB_TaxComputationAcct_ID");
if (ii == null) return 0;
return Convert.ToInt32(ii);
}
/** Set Tax Declaration.
@param VAB_TaxRateComputation_ID Define the declaration to the tax authorities */
public void SetVAB_TaxRateComputation_ID (int VAB_TaxRateComputation_ID)
{
if (VAB_TaxRateComputation_ID < 1) throw new ArgumentException ("VAB_TaxRateComputation_ID is mandatory.");
Set_ValueNoCheck ("VAB_TaxRateComputation_ID", VAB_TaxRateComputation_ID);
}
/** Get Tax Declaration.
@return Define the declaration to the tax authorities */
public int GetVAB_TaxRateComputation_ID() 
{
Object ii = Get_Value("VAB_TaxRateComputation_ID");
if (ii == null) return 0;
return Convert.ToInt32(ii);
}
/** Set Tax.
@param VAB_TaxRate_ID Tax identifier */
public void SetVAB_TaxRate_ID (int VAB_TaxRate_ID)
{
throw new ArgumentException ("VAB_TaxRate_ID Is virtual column");
}
/** Get Tax.
@return Tax identifier */
public int GetVAB_TaxRate_ID() 
{
Object ii = Get_Value("VAB_TaxRate_ID");
if (ii == null) return 0;
return Convert.ToInt32(ii);
}
/** Set Account Date.
@param DateAcct General Ledger Date */
public void SetDateAcct (DateTime? DateAcct)
{
throw new ArgumentException ("DateAcct Is virtual column");
}
/** Get Account Date.
@return General Ledger Date */
public DateTime? GetDateAcct() 
{
return (DateTime?)Get_Value("DateAcct");
}
/** Set Description.
@param Description Optional short description of the record */
public void SetDescription (String Description)
{
if (Description != null && Description.Length > 255)
{
log.Warning("Length > 255 - truncated");
Description = Description.Substring(0,255);
}
Set_Value ("Description", Description);
}
/** Get Description.
@return Optional short description of the record */
public String GetDescription() 
{
return (String)Get_Value("Description");
}
/** Set Accounting Fact.
@param Actual_Acct_Detail_ID Accounting Fact */
public void SetActual_Acct_Detail_ID (int Actual_Acct_Detail_ID)
{
if (Actual_Acct_Detail_ID < 1) throw new ArgumentException ("Actual_Acct_Detail_ID is mandatory.");
Set_ValueNoCheck ("Actual_Acct_Detail_ID", Actual_Acct_Detail_ID);
}
/** Get Accounting Fact.
@return Accounting Fact */
public int GetActual_Acct_Detail_ID() 
{
Object ii = Get_Value("Actual_Acct_Detail_ID");
if (ii == null) return 0;
return Convert.ToInt32(ii);
}
/** Set Line No.
@param Line Unique line for this document */
public void SetLine (int Line)
{
Set_Value ("Line", Line);
}
/** Get Line No.
@return Unique line for this document */
public int GetLine() 
{
Object ii = Get_Value("Line");
if (ii == null) return 0;
return Convert.ToInt32(ii);
}
}

}