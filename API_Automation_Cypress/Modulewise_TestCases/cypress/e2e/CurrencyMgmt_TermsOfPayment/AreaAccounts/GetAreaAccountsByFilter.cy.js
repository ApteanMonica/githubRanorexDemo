describe("Get Area Accounts By Filter", () => {
  var context = "";
  var BaseURL = "localhost:8080//api-et-basis-v1-";
  var AreaBaseURL = "localhost:8080//api-rw-fi-v1-";

  it("prerequisites", () => {
    cy.login("rs", "rsc", "rs2", "100").then((res) => {
      context = res.body.Context;
    });
  });

  //This testcase is to verify the user is able to get value by the search  filter
  it("Verify the user is able to get value by the search  filter", () => {
    cy.request({
      method: "Post",
      url: `${AreaBaseURL}AreaAccountService.svc/json/Area/AreaAccountsByFilterContainer?context=${context}`,

      body: {
        Filter: [
          {
            FieldName: "AreaId",
            Operator: "Equal",
            Values: ["1"],
          },
          {
            FieldName: "AreaAccountId",
            Operator: "Equal",
            Values: ["KB"],
          },
          {
            FieldName: "Status",
            Operator: "Equal",
            Values: ["A"],
          },
        ],
      },
    }).then((response) => {
      //Assertions
      assert.equal(response.body.Value[0]["AccountClosure"], null);
      assert.equal(response.body.Value[0]["AddressId"], null);
      assert.equal(response.body.Value[0]["AreaAccountId"], "KB");
      assert.equal(response.body.Value[0]["AreaId"], "1");
      assert.equal(response.body.Value[0]["AreaPartitioningId"], null);
      assert.equal(response.body.Value[0]["Billing"], null);
      assert.equal(response.body.Value[0]["BillingMonth"], null);
      assert.equal(response.body.Value[0]["BillingMonthFrom"], null);
      assert.equal(response.body.Value[0]["BillingMonthTo"], null);
      assert.equal(response.body.Value[0]["BillingType"], null);
      assert.equal(response.body.Value[0]["BillingYear"], null);
      assert.equal(response.body.Value[0]["BillingYearFrom"], null);
      assert.equal(response.body.Value[0]["BillingYearTo"], null);
      assert.equal(response.body.Value[0]["ClearingLevel"], null);
      assert.equal(response.body.Value[0]["Code1"], null);
      assert.equal(response.body.Value[0]["Code2"], null);
      assert.equal(response.body.Value[0]["Code3"], null);
      assert.equal(response.body.Value[0]["CompanyId"], "100");
      assert.equal(response.body.Value[0]["CostCentreBilling"], null);
      assert.equal(response.body.Value[0]["CreditAccountId"], null);
      assert.equal(response.body.Value[0]["CreditAccountId1"], null);
      assert.equal(response.body.Value[0]["CustomerCollectiveAccount"], null);
      assert.equal(response.body.Value[0]["CustomerPaymentsBankId"], null);
      assert.equal(response.body.Value[0]["Date1"], null);
      assert.equal(response.body.Value[0]["Date2"], null);
      assert.equal(response.body.Value[0]["Date3"], null);
      assert.equal(response.body.Value[0]["Date4"], null);
      assert.equal(response.body.Value[0]["Date5"], null);
      assert.equal(response.body.Value[0]["DebitAccountId"], null);
      assert.equal(
        response.body.Value[0]["Description"],
        "Kontrollnummer Bestand"
      );
      assert.equal(response.body.Value[0]["Description1"], null);
      assert.equal(response.body.Value[0]["DueDateDays"], null);
      assert.equal(response.body.Value[0]["DunningId"], null);
      assert.equal(response.body.Value[0]["DunningVariantId"], null);
      assert.equal(response.body.Value[0]["FixedAreaAccount1"], null);
      assert.equal(response.body.Value[0]["FixedAreaAccount2"], null);
      assert.equal(response.body.Value[0]["FixedAreaAccount3"], null);
      assert.equal(response.body.Value[0]["FixedAreaAccount4"], null);
      assert.equal(response.body.Value[0]["FixedAreaAccount5"], null);
      assert.equal(response.body.Value[0]["FixedAreaAccount6"], null);
      assert.equal(response.body.Value[0]["FixedPurchaseAccount"], null);
      assert.equal(response.body.Value[0]["FreelyUsableField1"], null);
      assert.equal(response.body.Value[0]["FreelyUsableField2"], null);
      assert.equal(response.body.Value[0]["FreelyUsableField3"], null);
      assert.equal(response.body.Value[0]["FreelyUsableField4"], null);
      assert.equal(response.body.Value[0]["FreelyUsableField5"], null);
      assert.equal(response.body.Value[0]["HierarchicCompanyId"], "100");
      assert.equal(response.body.Value[0]["InterestAccountId"], null);
      assert.equal(
        response.body.Value[0]["InterestCalculationIndicator"],
        null
      );
      assert.equal(response.body.Value[0]["Master"], "N");
      assert.equal(
        response.body.Value[0]["PaymentMethodCustomerPayments"],
        null
      );
      assert.equal(response.body.Value[0]["PaymentMethodSupplier"], null);
      assert.equal(response.body.Value[0]["Phase"], null);
      assert.equal(response.body.Value[0]["PhaseId"], null);
      assert.equal(response.body.Value[0]["PlanState"], null);
      assert.equal(response.body.Value[0]["PlannableFrom"], null);
      assert.equal(response.body.Value[0]["PlannableTo"], null);
      assert.equal(response.body.Value[0]["Position"], null);
      assert.equal(response.body.Value[0]["PrepaymentsAccountId"], null);
      assert.equal(response.body.Value[0]["ProjectId"], null);
      assert.equal(response.body.Value[0]["ProjectStage"], null);
      assert.equal(response.body.Value[0]["Quantity1"], null);
      assert.equal(response.body.Value[0]["Quantity2"], null);
      assert.equal(response.body.Value[0]["Status"], "A");
      assert.equal(response.body.Value[0]["SubPosition"], null);
      assert.equal(response.body.Value[0]["SupplierCollectiveAccount"], null);
      assert.equal(response.body.Value[0]["SupplierPaymentsBankId"], null);
      assert.equal(response.body.Value[0]["Text"], null);
      assert.equal(response.body.Value[0]["User"], null);
      assert.equal(response.body.Value[0]["UserId"], null);
      assert.equal(response.body.Value[0]["VatOption"], null);
    });
  });
});
