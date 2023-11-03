describe("Update terms of payment text validations", () => {
  //Parameters used to Terms of payment text
  var context = "";
  var BaseURL = "localhost:8080//api-rw-fi-v1-";
  var languageCode = "D";
  var termsOfPaymentCode = 666;
  var description = "API Automation";
  var Length;

  /**
   * This it block is used to generate the context using login credentials which will be used in further it blocks
   */
  it("prerequisites", () => {
    cy.login("rs", "rsc", "rs2", "100").then((res) => {
      context = res.body.Context;
    });
  });

  /**
   * This it block is used to verify user is able to update Terms of payment text by passing correct values in the request
   */
  it("UpdateTermsOfPaymentText", () => {
    const updateDescription = Math.random().toString(36).substring(2, 7);

    cy.request({
      method: "PUT",
      url: `${BaseURL}TermsOfPaymentService.svc/json/TermsOfPayment/${termsOfPaymentCode}/TermsOfPaymentText?context=${context}`,
      Headers: {},
      body: {
        Language: languageCode,
        Description: updateDescription,
      },
    }).then((response) => {
      //assertions
      assert.equal(response.body.Value["Code"], termsOfPaymentCode);
      assert.equal(response.body.Value["Language"], languageCode);
      assert.equal(response.body.Value["Description"], updateDescription);
      expect(response.status).to.eq(200);
    });
  });

  /**
   * This it block is used to verify the user is not able to update Terms of payment text by passing blank in mandatory fields request
   */
  it("UpdateTermsOfPaymentTextWithoutMandatoryFields", () => {
    const updateDescription = Math.random().toString(36).substring(2, 7);

    cy.request({
      method: "PUT",
      url: `${BaseURL}TermsOfPaymentService.svc/json/TermsOfPayment/${termsOfPaymentCode}/TermsOfPaymentText?context=${context}`,
      Headers: {},
      body: {
        Language: null,
        Description: updateDescription,
      },
    }).then((response) => {
      //assertions
      assert.equal(
        response.body.Messages[0]["Id"],
        "rssoft.common.message.ParameterNullOrEmptyError"
      );
      //"The value of the parameter 'SPRA_CD' was not found or not entered"
      assert.equal(
        response.body.Messages[0]["Text"],
        "Der Wert des Parameters 'SPRA_CD' wurde nicht gefunden oder nicht eingegeben"
      );
      expect(response.status).to.eq(200);
    });
  });

  /**
   * This it block is used to verify user is able to update Terms of payment text by passing incorrect value in code
   */
  it("UpdateTermsOfPaymentTextWithoutTermsOfPaymnentCode", () => {
    const updateDescription = Math.random().toString(36).substring(2, 7);
    var invalidTermsOfPaymentCode = 12323;

    cy.request({
      method: "PUT",
      url: `${BaseURL}TermsOfPaymentService.svc/json/TermsOfPayment/${invalidTermsOfPaymentCode}/TermsOfPaymentText?context=${context}`,
      Headers: {},
      body: {
        Language: languageCode,
        Description: updateDescription,
      },
    }).then((response) => {
      //assertions
      assert.equal(
        response.body.Messages[0]["Id"],
        "rssoft.bfw.rw.fi.serv.TermsOfPaymentNotExistsError"
      );
      //"There is no payment term text for the specified payment term code"
      assert.equal(
        response.body.Messages[0]["Text"],
        "Für den angegebenen Zahlungsbedingungscode existiert kein Zahlungsbedingungstext"
      );
      expect(response.status).to.eq(200);
    });
  });

  /**
   * This it block is used to verify user is able to update Terms of payment text by passing incorrect values in language
   */
  it("UpdateTermsOfPaymentTextWithoutPassingValidLanguageCode", () => {
    const updateDescription = Math.random().toString(36).substring(2, 7);
    var invalidLanguageCode = "Z";

    cy.request({
      method: "PUT",
      url: `${BaseURL}TermsOfPaymentService.svc/json/TermsOfPayment/${termsOfPaymentCode}/TermsOfPaymentText?context=${context}`,
      Headers: {},
      body: {
        Language: invalidLanguageCode,
        Description: updateDescription,
      },
    }).then((response) => {
      //assertions
      assert.equal(
        response.body.Messages[0]["Id"],
        "rssoft.bfw.rw.fi.serv.LanguageCodeNotExistsError"
      );
      //"There is no payment terms text set for the specified language code!"
      assert.equal(
        response.body.Messages[0]["Text"],
        "Für den angegebenen Sprachcode existiert kein Zahlungsbedingungen-Textsatz!"
      );
      expect(response.status).to.eq(200);
    });
  });

  /**
   * This it block is used to verify if the user is not able to update Terms of payment text when passing the request with empty object
   */
  it("UpdateTermsOfPaymentTextWithEmptyBody", () => {
    cy.request({
      method: "PUT",
      url: `${BaseURL}TermsOfPaymentService.svc/json/TermsOfPayment/${termsOfPaymentCode}/TermsOfPaymentText?context=${context}`,
      Headers: {},
      body: {},
    }).then((response) => {
      //assertions
      assert.equal(
        response.body.Messages[0]["Id"],
        "rssoft.common.message.ParameterNullOrEmptyError"
      );
      //"The value of the parameter 'SPRA_CD' was not found or not entered"
      assert.equal(
        response.body.Messages[0]["Text"],
        "Der Wert des Parameters 'SPRA_CD' wurde nicht gefunden oder nicht eingegeben"
      );

      assert.equal(
        response.body.Messages[1]["Id"],
        "rssoft.common.message.ParameterNullOrEmptyError"
      );
      //"The value of the parameter 'ZLTX_BEZ' was not found or not entered"
      assert.equal(
        response.body.Messages[1]["Text"],
        "Der Wert des Parameters 'ZLTX_BEZ' wurde nicht gefunden oder nicht eingegeben"
      );
      expect(response.status).to.eq(200);
    });
  });

  /**
   * This it block is used to verify the user did not update terms of payment text with an invalid context
   */
  it("UpdateTermsOfPaymentTextWithInvalidContext", () => {
    const updateDescription = Math.random().toString(36).substring(2, 7);
    var invalidContext = "BNDSBCSADJCJWDVCDVCLDBCWLDBC";

    cy.request({
      method: "PUT",
      url: `${BaseURL}TermsOfPaymentService.svc/json/TermsOfPayment/${termsOfPaymentCode}/TermsOfPaymentText?context=${invalidContext}`,
      Headers: {},
      body: {
        Language: languageCode,
        Description: updateDescription,
      },
    }).then((response) => {
      //assertions
      assert.equal(
        response.body.Messages[0]["Id"],
        "rssoft.common.rs2.authentication.InvalidContextValueError"
      );
      //"The specified login context (BNDSBCSADJCJWDVCDVCLDBCWLDBC) is invalid"
      assert.equal(
        response.body.Messages[0]["Text"],
        "Der angegebene Anmelde-Context (BNDSBCSADJCJWDVCDVCLDBCWLDBC) ist ungültig"
      );
      expect(response.status).to.eq(200);
    });
  });

  /**
   * This it block is used to verify user is not able to update Terms of payment text , if the records doesn't exist in terms of payment text
   */
  it("UpdateTermsOfPaymentTextWithNonExistingRecord", () => {
    cy.request({
      method: "DELETE",
      url: `${BaseURL}TermsOfPaymentService.svc/json/TermsOfPayment/${termsOfPaymentCode}/TermsOfPaymentText?languageCode=E&context=${context}`,
    });

    cy.request({
      method: "PUT",
      url: `${BaseURL}TermsOfPaymentService.svc/json/TermsOfPayment/${termsOfPaymentCode}/TermsOfPaymentText?context=${context}`,
      Headers: {},
      body: {
        Language: "E",
        Description: "API TEST FOR UPDATE 143",
      },
    }).then((response) => {
      //assertions
      assert.equal(
        response.body.Messages[0]["Id"],
        "rssoft.bfw.rw.serv.RecordDoesNotExistsError"
      );
      //"The value of the parameter 'SPRA_CD' was not found or not entered"
      assert.equal(
        response.body.Messages[0]["Text"],
        "Der Datensatz mit diesem item existiert nicht"
      );
      expect(response.status).to.eq(200);
    });
  });

  /**
   * This it block is used to verify user is able to update Terms of payment text by passing correct values in the request
   */
  it("UpdateTermsOfPaymentText", () => {
    const updateDescription = Math.random().toString(36).substring(2, 7);

    cy.request({
      method: "PUT",
      url: `${BaseURL}TermsOfPaymentService.svc/json/TermsOfPayment/${termsOfPaymentCode}/TermsOfPaymentText?context=${context}`,

      body: {
        Language: languageCode,
        Description: updateDescription,
      },
    }).then((response) => {
      //assertions
      assert.equal(response.body.Value["Code"], termsOfPaymentCode);
      assert.equal(response.body.Value["Language"], languageCode);
      assert.equal(response.body.Value["Description"], updateDescription);
      expect(response.status).to.eq(200);
    });
  });

  /**
   * This it block is used to verify if the user not having the permission to Update a terms of payment text, can not update a Terms of payment text
   */
  var context2 = "";
  var updateDescription = "Test Description";

  it("UpdateTermsOfPaymentTextWithUnauthorizedUser", () => {
    cy.login("TEST", "rsc", "rs2", "200")
      .then((res) => {
        context2 = res.body.Context;
        cy.log(context2);
      })
      .then(() => {
        cy.request({
          method: "PUT",
          url: `${BaseURL}TermsOfPaymentService.svc/json/TermsOfPayment/${termsOfPaymentCode}/TermsOfPaymentText?context=${context2}`,
          Headers: {},
          body: {
            Language: languageCode,
            Description: updateDescription,
          },
        }).then((response) => {
          //assertions
          assert.equal(
            response.body.Messages[0]["Id"],
            "rssoft.bfw.common.AccessDeniedError"
          );
          //"Access denied - To access this resource, you need the following right: API-RW-FI-TERMSOFPAYMENTSERVICE / *!"
          assert.equal(
            response.body.Messages[0]["Text"],
            "Access denied - To access this resource, you need the following right: API-RW-FI-TERMSOFPAYMENTSERVICE / *!"
          );
          expect(response.status).to.eq(200);
        });
      });
  });
});
