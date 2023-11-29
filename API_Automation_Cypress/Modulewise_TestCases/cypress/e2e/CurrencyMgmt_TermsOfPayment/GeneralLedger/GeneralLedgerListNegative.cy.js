describe("General Ledger Negative", () => {
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

  //This testcase is to verify if the user not having permission to get all list of account, can not get all list of account
  it("Verify if the user not having permission to get all list of account, can not get all list of account", () => {
    var idValue = "d";
    cy.request({
      method: "GET",
      url: `${BaseURL}GeneralLedgerService.svc/json/GeneralLedgerList?context=${context2}`,
    }).then((response) => {
      //Access denied - To access this resource, you need the following right: API-RW-FI-GENERALLEDGERSERVICE / *!
      assert.equal(
        response.body.Messages[0]["Text"],
        "Access denied - To access this resource, you need the following right: API-RW-FI-GENERALLEDGERSERVICE / *!"
      );
      expect(response.status).to.eq(200);
    });
  });

  //This testcase is to verify the user is not able to get list of account with an invalid context
  it("Verify the user is not able to get list of account with an invalid context", () => {
    var idValue = "d";
    cy.request({
      method: "GET",
      url: `${BaseURL}GeneralLedgerService.svc/json/GeneralLedgerList?context=123456789`,
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
