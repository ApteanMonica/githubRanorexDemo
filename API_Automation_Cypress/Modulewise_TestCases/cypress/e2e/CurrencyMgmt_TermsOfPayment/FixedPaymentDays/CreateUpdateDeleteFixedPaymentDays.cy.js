describe("Fixed Payment Days Validations", () => {
  //Parameters used for fixed payment days
  var context = "";
  var BaseURL = "localhost:8080//api-rw-fi-v1-";
  var termsOfPaymentCode = "031";
  var invoiceDateDay = 31;
  var cashDiscountEndDay1 = 11;
  var cashDiscountEndMonth1 = 7;
  var cashDiscountEndDay2 = 21;
  var cashDiscountEndMonth2 = 9;
  var dueDateDay = 25;
  var dueDateMonth = 10;
  var invoiceDateMonth = 28;
  var serialNumber = 1;

  /**
   * This it block is used to generate the context using login credentials which will be used in further it blocks
   */
  it("prerequisites", () => {
    cy.login("rs", "rsc", "rs2", "100").then((res) => {
      context = res.body.Context;
    });
  });

  /**
   * This it block is used to create new fixed payment days and validate the response
   */
  it("createFixedPaymentDays", () => {
    cy.request({
      method: "POST",
      url: `${BaseURL}TermsOfPaymentService.svc/json/TermsOfPayment/${termsOfPaymentCode}/FixedPaymentDays?context=${context}`,

      body: [
        {
          InvoiceDateDay: invoiceDateDay,
          CashDiscountEndDay1: cashDiscountEndDay1,
          CashDiscountEndMonth1: cashDiscountEndMonth1,
          CashDiscountEndDay2: cashDiscountEndDay2,
          CashDiscountEndMonth2: cashDiscountEndMonth2,
          DueDateDay: dueDateDay,
          DueDateMonth: dueDateMonth,
          InvoiceDateMonth: invoiceDateMonth,
          SerialNumber: serialNumber,
        },
      ],
    }).then((response) => {
      //assertions

      assert.equal(response.body.Value[0]["InvoiceDateDay"], invoiceDateDay);
      assert.equal(
        response.body.Value[0]["CashDiscountEndDay1"],
        cashDiscountEndDay1
      );
      assert.equal(
        response.body.Value[0]["CashDiscountEndMonth1"],
        cashDiscountEndMonth1
      );
      assert.equal(
        response.body.Value[0]["CashDiscountEndDay2"],
        cashDiscountEndDay2
      );
      assert.equal(
        response.body.Value[0]["CashDiscountEndMonth2"],
        cashDiscountEndMonth2
      );
      assert.equal(response.body.Value[0]["InvoiceDateDay"], invoiceDateDay);
      assert.equal(response.body.Value[0]["DueDateDay"], dueDateDay);
      // assert.equal(response.body.Value[0]["InvoiceDateMonth"], invoiceDateMonth)
      assert.equal(response.body.Value[0]["DueDateMonth"], dueDateMonth);
      assert.equal(response.body.Value[0]["SerialNumber"], serialNumber);
      assert.equal(response.body.Value[0]["Code"], termsOfPaymentCode);
      expect(response.status).to.eq(200);
    });
  });

  /**
   * This it block is used to update the existing fixed payment days and validate the response
   */
  it("updateFixedPaymentDays", () => {
    var cashDiscountEndDay2 = 27;
    var cashDiscountEndMonth2 = 10;
    var dueDateDay = 26;
    cy.request({
      method: "PUT",
      url: `${BaseURL}TermsOfPaymentService.svc/json/TermsOfPayment/${termsOfPaymentCode}/FixedPaymentDays?context=${context}`,

      body: [
        {
          InvoiceDateDay: invoiceDateDay,
          CashDiscountEndDay1: cashDiscountEndDay1,
          CashDiscountEndMonth1: cashDiscountEndMonth1,
          CashDiscountEndDay2: cashDiscountEndDay2,
          CashDiscountEndMonth2: cashDiscountEndMonth2,
          DueDateDay: dueDateDay,
          DueDateMonth: dueDateMonth,
          InvoiceDateMonth: invoiceDateMonth,
          SerialNumber: serialNumber,
        },
      ],
    }).then((response) => {
      //assertions

      assert.equal(response.body.Value[0]["InvoiceDateDay"], invoiceDateDay);
      assert.equal(
        response.body.Value[0]["CashDiscountEndDay1"],
        cashDiscountEndDay1
      );
      assert.equal(
        response.body.Value[0]["CashDiscountEndMonth1"],
        cashDiscountEndMonth1
      );
      assert.equal(
        response.body.Value[0]["CashDiscountEndDay2"],
        cashDiscountEndDay2
      );
      assert.equal(
        response.body.Value[0]["CashDiscountEndMonth2"],
        cashDiscountEndMonth2
      );
      assert.equal(response.body.Value[0]["InvoiceDateDay"], invoiceDateDay);
      assert.equal(response.body.Value[0]["DueDateDay"], dueDateDay);
      // assert.equal(response.body.Value[0]["InvoiceDateMonth"], invoiceDateMonth)
      assert.equal(response.body.Value[0]["DueDateMonth"], dueDateMonth);
      assert.equal(response.body.Value[0]["SerialNumber"], serialNumber);
      assert.equal(response.body.Value[0]["Code"], termsOfPaymentCode);
      expect(response.status).to.eq(200);
    });
  });
  /**
   * This it block is used  delete the existing terms of payment code and to validate the deleted code by get method
   */
  it("deleteFixedPaymentDays", () => {
    cy.request({
      method: "DELETE",
      url: `${BaseURL}TermsOfPaymentService.svc/json/TermsOfPayment/${termsOfPaymentCode}/FixedPaymentDays/1?context=${context}`,
    }).then((response) => {
      //assertions
      expect(response.status).to.eq(200);
    });
  });

  it("updateTermsOfPayment", () => {
    var updateDescription = "Updating DayUntilInvoiceDate";
    cy.request({
      method: "PUT",
      url: `${BaseURL}TermsOfPaymentService.svc/json/TermsOfPayment?context=${context}`,

      body: {
        Code: termsOfPaymentCode,
        State: 9,
        CashDiscountPeriod1: 2,
        CashDiscountPct1: 4.0,
        NetDays: 30,
        CashDiscountPeriod2: 17,
        CashDiscountPct2: 3.0,
        Description: updateDescription,
        ChangeStates: 1,
        Edi: "0",
        DayUntilInvoiceDate: 1,
      },
    }).then((response) => {
      //assertions

      expect(response.status).to.eq(200);
    });
  });
});
