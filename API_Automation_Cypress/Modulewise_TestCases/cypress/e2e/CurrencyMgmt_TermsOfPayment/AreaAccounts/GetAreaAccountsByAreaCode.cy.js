describe("Get Area Accounts By Area Code", () => {
  var context = "";
  var BaseURL = "localhost:8080//api-et-basis-v1-";
  var AreaBaseURL = "localhost:8080//api-rw-fi-v1-";
  var AreaId = "1";
  var AreaCode = "KB";

  it("prerequisites", () => {
    cy.login("rs", "rsc", "rs2", "100").then((res) => {
      context = res.body.Context;
    });
  });

  //This testcase is to verify the user is able to get area account by area code
  it("Verify the user is able to get area account by area code", () => {
    cy.request({
      method: "Get",
      url: `${AreaBaseURL}AreaAccountService.svc/json/Area/${AreaId}/AreaAccounts/${AreaCode}?context=${context}`,
    }).then((response) => {
      //Assertions
      assert.equal(response.body.Value["AccountClosure"], null);
      assert.equal(response.body.Value["AddressId"], null);
      assert.equal(response.body.Value["AreaAccountId"], "KB");
      assert.equal(response.body.Value["AreaId"], "1");
      assert.equal(response.body.Value["AreaPartitioningId"], null);
      assert.equal(response.body.Value["Billing"], null);
      assert.equal(response.body.Value["BillingMonth"], null);
      assert.equal(response.body.Value["BillingMonthFrom"], null);
      assert.equal(response.body.Value["BillingMonthTo"], null);
      assert.equal(response.body.Value["BillingType"], null);
      assert.equal(response.body.Value["BillingYear"], null);
      assert.equal(response.body.Value["BillingYearFrom"], null);
      assert.equal(response.body.Value["BillingYearTo"], null);
      assert.equal(response.body.Value["ClearingLevel"], null);
      assert.equal(response.body.Value["Code1"], null);
      assert.equal(response.body.Value["Code2"], null);
      assert.equal(response.body.Value["Code3"], null);
      assert.equal(response.body.Value["CompanyId"], "100");
      assert.equal(response.body.Value["CostCentreBilling"], null);
      assert.equal(response.body.Value["CreditAccountId"], null);
      assert.equal(response.body.Value["CreditAccountId1"], null);
      assert.equal(response.body.Value["CustomerCollectiveAccount"], null);
      assert.equal(response.body.Value["CustomerPaymentsBankId"], null);
      assert.equal(response.body.Value["Date1"], null);
      assert.equal(response.body.Value["Date2"], null);
      assert.equal(response.body.Value["Date3"], null);
      assert.equal(response.body.Value["Date4"], null);
      assert.equal(response.body.Value["Date5"], null);
      assert.equal(response.body.Value["DebitAccountId"], null);
      assert.equal(
        response.body.Value["Description"],
        "Kontrollnummer Bestand"
      );
      assert.equal(response.body.Value["Description1"], null);
      assert.equal(response.body.Value["DueDateDays"], null);
      assert.equal(response.body.Value["DunningId"], null);
      assert.equal(response.body.Value["DunningVariantId"], null);
      assert.equal(response.body.Value["FixedAreaAccount1"], null);
      assert.equal(response.body.Value["FixedAreaAccount2"], null);
      assert.equal(response.body.Value["FixedAreaAccount3"], null);
      assert.equal(response.body.Value["FixedAreaAccount4"], null);
      assert.equal(response.body.Value["FixedAreaAccount5"], null);
      assert.equal(response.body.Value["FixedAreaAccount6"], null);
      assert.equal(response.body.Value["FixedPurchaseAccount"], null);
      assert.equal(response.body.Value["FreelyUsableField1"], null);
      assert.equal(response.body.Value["FreelyUsableField2"], null);
      assert.equal(response.body.Value["FreelyUsableField3"], null);
      assert.equal(response.body.Value["FreelyUsableField4"], null);
      assert.equal(response.body.Value["FreelyUsableField5"], null);
      assert.equal(response.body.Value["HierarchicCompanyId"], "100");
      assert.equal(response.body.Value["InterestAccountId"], null);
      assert.equal(response.body.Value["InterestCalculationIndicator"], null);
      assert.equal(response.body.Value["Master"], "N");
      assert.equal(response.body.Value["PaymentMethodCustomerPayments"], null);
      assert.equal(response.body.Value["PaymentMethodSupplier"], null);
      assert.equal(response.body.Value["Phase"], null);
      assert.equal(response.body.Value["PhaseId"], null);
      assert.equal(response.body.Value["PlanState"], null);
      assert.equal(response.body.Value["PlannableFrom"], null);
      assert.equal(response.body.Value["PlannableTo"], null);
      assert.equal(response.body.Value["Position"], null);
      assert.equal(response.body.Value["PrepaymentsAccountId"], null);
      assert.equal(response.body.Value["ProjectId"], null);
      assert.equal(response.body.Value["ProjectStage"], null);
      assert.equal(response.body.Value["Quantity1"], null);
      assert.equal(response.body.Value["Quantity2"], null);
      assert.equal(response.body.Value["Status"], "A");
      assert.equal(response.body.Value["SubPosition"], null);
      assert.equal(response.body.Value["SupplierCollectiveAccount"], null);
      assert.equal(response.body.Value["SupplierPaymentsBankId"], null);
      assert.equal(response.body.Value["Text"], null);
      assert.equal(response.body.Value["User"], null);
      assert.equal(response.body.Value["UserId"], null);
      assert.equal(response.body.Value["VatOption"], null);
    });
  });
});
