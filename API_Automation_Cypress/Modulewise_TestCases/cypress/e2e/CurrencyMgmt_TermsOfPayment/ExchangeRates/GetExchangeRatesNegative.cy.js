describe("Exchange Rate Negative", () => {
  var context = "";
  var context2 = "";
  var BaseURL = "localhost:8080//api-rw-fi-v1-";

  it("prerequisites", () => {
    cy.login("rs", "rsc", "rs2", "100").then((res) => {
      context = res.body.Context;
    });
  });

  //To generate context for user 200 who dont have permission to access the get areas

  it("Generate Context 2", () => {
    cy.login("rs", "rsc", "rs2", "200").then((res) => {
      context2 = res.body.Context;
    });
  });

  //This testcase is to verify if the user not having permission to get all Exchange Rate, can not get Exchange Rate
  it("Verify if the user not having permission to get all Exchange Rate, can not get Exchange Rate", () => {
    cy.request({
      method: "POST",
      url: `${BaseURL}CurrencyService.svc/json/Currency/ExchangeRatesByFilterContainer?context=${context2}`,

      body: {
        Filter: [
          {
            FieldName: "ExchangeRateTypeId",
            Operator: "Equal",
            Values: ["M"],
          },
          {
            FieldName: "Date",
            Operator: "Equal",
            Values: ["2023-10-26T00:00:00"],
          },
        ],
        Sort: [
          {
            FieldName: "CurrencyId",
            Descending: "true",
          },
        ],
      },
    }).then((response) => {
      //assertions
      assert.equal(
        response.body.Messages[0]["Id"],
        "rssoft.bfw.common.AccessDeniedError"
      );
      //Access denied - To access this resource, you need the following right: API-RW-FI-CURRENCYSERVICE / *!
      assert.equal(
        response.body.Messages[0]["Text"],
        "Access denied - To access this resource, you need the following right: API-RW-FI-CURRENCYSERVICE / *!"
      );
      expect(response.status).to.eq(200);
    });
  });

  //This testcase is to verify the user is not able to get Exchange Rate with an invalid context
  it("Verify the user is not able to get Exchange Rate with an invalid context", () => {
    cy.request({
      method: "POST",
      url: `${BaseURL}CurrencyService.svc/json/Currency/ExchangeRatesByFilterContainer?context=123456789`,

      body: {
        Filter: [
          {
            FieldName: "ExchangeRateTypeId",
            Operator: "Equal",
            Values: ["M"],
          },
          {
            FieldName: "Date",
            Operator: "Equal",
            Values: ["2023-10-26T00:00:00"],
          },
        ],
        Sort: [
          {
            FieldName: "CurrencyId",
            Descending: "true",
          },
        ],
      },
    }).then((response) => {
      //assertions
      assert.equal(
        response.body.Messages[0]["Id"],
        "rssoft.common.rs2.authentication.InvalidContextValueError"
      );
      //"The specified login context (123456789) is invalid"
      assert.equal(
        response.body.Messages[0]["Text"],
        "Der angegebene Anmelde-Context (123456789) ist ungültig"
      );
      expect(response.status).to.eq(200);
    });
  });
});
