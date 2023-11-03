describe("Terms of payment Validations", () => {
  var context = "";
  var BaseURL = "localhost:8080//";

  /**
   * This it block is used to generate the context using login credentials which will be used in further it blocks
   */
  it("prerequisites", () => {
    cy.login("rs", "rsc", "rs2", "100").then((res) => {
      context = res.body.Context;
    });
  });

  var code = "100";

  /**
   * This it block is used to get the "Terms of payment" details using "Terms of payment code"
   */
  it("GetTermsOfPayment", () => {
    cy.request({
      method: "GET",
      url: `${BaseURL}api-rw-fi-v1-TermsOfPaymentService.svc/json/TermsOfPayment/${code}?context=${context}`,
    }).then((response) => {
      //assertions
      assert.equal(response.body.Value["CashDiscountPct1"], 2);
      assert.equal(response.body.Value["CashDiscountPct2"], 1);
      assert.equal(response.body.Value["CashDiscountPeriod1"], 11);
      assert.equal(response.body.Value["CashDiscountPeriod2"], 21);
      assert.equal(response.body.Value["ChangeStates"], "0");
      assert.equal(response.body.Value["Code"], code);
      assert.equal(response.body.Value["DayUntilInvoiceDate"], "0");
      assert.equal(response.body.Value["DefinableField1"], null);
      assert.equal(response.body.Value["DefinableField2"], null);
      assert.equal(response.body.Value["DefinableField3"], null);
      assert.equal(response.body.Value["DefinableField4"], null);
      assert.equal(response.body.Value["DefinableField5"], null);
      assert.equal(
        response.body.Value["Description"],
        "14 Tage 2%, 30 Tage netto"
      );
      assert.equal(response.body.Value["Edi"], "1");
      assert.equal(response.body.Value["NetDays"], "30");
      assert.equal(response.body.Value["State"], "0");
      assert.equal(response.body.Value["Ultimo"], null);
      assert.equal(response.body.Value["ValutaDate"], null);
      assert.equal(response.body.Value["ValutaDays"], null);

      expect(response.status).to.eq(200);
    });
  });
});
