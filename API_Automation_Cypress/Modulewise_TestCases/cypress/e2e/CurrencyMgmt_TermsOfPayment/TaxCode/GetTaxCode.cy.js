describe("TaxCode ValIdations", () => {
  var context = "";
  var BaseURL = "localhost:8080//api-rw-fi-v1-";

  it("prerequisites", () => {
    cy.login("rs", "rsc", "rs2", "100").then((res) => {
      context = res.body.Context;
    });
  });

  //This testcase is to retrieve the get language
  it("GetTaxCode", () => {
    var idValue = "a";
    cy.request({
      method: "POST",
      url: `${BaseURL}TaxCodeAdministrationService.svc/json/TaxCode/TaxCodeByFilterContainer?context=${context}`,

      body: {
        Filter: [
          {
            FieldName: "Id",
            Operator: "Contains",
            Values: ["z"],
          },
        ],
      },
    }).then((response) => {
      //assertions
      assert.equal(response.body.Value[0]["CompanyId"], "100");
      assert.equal(response.body.Value[0]["CountryId"], "AT");
      assert.equal(response.body.Value[0]["Distribution"], 1);
      assert.equal(response.body.Value[0]["Id"], "EUZ");
      assert.equal(response.body.Value[0]["MarginschemePercent"], null);
      assert.equal(response.body.Value[0]["NonDeductibleAccountId"], null);
      assert.equal(response.body.Value[0]["Percent"], "0.00");
      assert.equal(response.body.Value[0]["ReductionTaxId"], null);
      assert.equal(response.body.Value[0]["RefId"], 2);
      assert.equal(response.body.Value[0]["State"], "A");
      assert.equal(response.body.Value[0]["SummaryDeclaration"], 0);
      assert.equal(response.body.Value[0]["SuspenseAccountId"], null);
      assert.equal(response.body.Value[0]["TaxBurden"], 0);
      assert.equal(
        response.body.Value[0]["Text1"],
        "Einfuhrumsatzsteuer Zollamt"
      );
      assert.equal(response.body.Value[0]["Text2"], null);
      assert.equal(response.body.Value[0]["Type"], "U");
      assert.equal(response.body.Value[0]["Use"], "0");
      assert.equal(response.body.Value[0]["Zabil"], 0);

      cy.log("Length: " + response.body.Value.length);
      assert.equal(response.body.Value.length, "1");
      expect(response.status).to.eq(200);
    });
  });

  //This testcase is to retrieve the get language by passing multiple currency code values
  it("GetTaxCodeWithMultipleValue", () => {
    var idValue = ["EUZ", "UFA"];
    cy.request({
      method: "POST",
      url: `${BaseURL}TaxCodeAdministrationService.svc/json/TaxCode/TaxCodeByFilterContainer?context=${context}`,

      body: {
        Filter: [
          {
            FieldName: "Id",
            Operator: "In",
            Values: idValue,
          },
        ],
        Sort: [
          {
            FieldName: "Id",
          },
        ],
      },
    }).then((response) => {
      //assertions
      assert.equal(response.body.Value[0]["CompanyId"], "100");
      assert.equal(response.body.Value[0]["CountryId"], "AT");
      assert.equal(response.body.Value[0]["Distribution"], 1);
      assert.equal(response.body.Value[0]["Id"], "EUZ");
      assert.equal(response.body.Value[0]["MarginschemePercent"], null);
      assert.equal(response.body.Value[0]["NonDeductibleAccountId"], null);
      assert.equal(response.body.Value[0]["Percent"], "0.00");
      assert.equal(response.body.Value[0]["ReductionTaxId"], null);
      assert.equal(response.body.Value[0]["RefId"], 2);
      assert.equal(response.body.Value[0]["State"], "A");
      assert.equal(response.body.Value[0]["SummaryDeclaration"], 0);
      assert.equal(response.body.Value[0]["SuspenseAccountId"], null);
      assert.equal(response.body.Value[0]["TaxBurden"], 0);
      assert.equal(
        response.body.Value[0]["Text1"],
        "Einfuhrumsatzsteuer Zollamt"
      );
      assert.equal(response.body.Value[0]["Text2"], null);
      assert.equal(response.body.Value[0]["Type"], "U");
      assert.equal(response.body.Value[0]["Use"], "0");
      assert.equal(response.body.Value[0]["Zabil"], 0);

      assert.equal(response.body.Value[1]["CompanyId"], "100");
      assert.equal(response.body.Value[1]["CountryId"], "AT");
      assert.equal(response.body.Value[1]["Distribution"], null);
      assert.equal(response.body.Value[1]["Id"], "UFA");
      assert.equal(response.body.Value[1]["MarginschemePercent"], null);
      assert.equal(response.body.Value[1]["NonDeductibleAccountId"], null);
      assert.equal(response.body.Value[1]["Percent"], "0.00");
      assert.equal(response.body.Value[1]["ReductionTaxId"], null);
      assert.equal(response.body.Value[1]["RefId"], null);
      assert.equal(response.body.Value[1]["State"], "A");
      assert.equal(response.body.Value[1]["SummaryDeclaration"], "0");
      assert.equal(response.body.Value[1]["SuspenseAccountId"], null);
      assert.equal(response.body.Value[1]["TaxBurden"], null);
      assert.equal(response.body.Value[1]["Text1"], "Umbuchungen FA");
      assert.equal(response.body.Value[1]["Text2"], null);
      assert.equal(response.body.Value[1]["Type"], "0");
      assert.equal(response.body.Value[1]["Use"], "0");
      assert.equal(response.body.Value[1]["Zabil"], "0");

      cy.log("Length: " + response.body.Value.length);
      assert.equal(response.body.Value.length, "2");
      expect(response.status).to.eq(200);
    });
  });

  //This testcase is to retrieve the get language using sort
  it("GetTaxCodeWithSort", () => {
    var idValue = ["EUZ", "UFA"];
    cy.request({
      method: "POST",
      url: `${BaseURL}TaxCodeAdministrationService.svc/json/TaxCode/TaxCodeByFilterContainer?context=${context}`,

      body: {
        Filter: [
          {
            FieldName: "Id",
            Operator: "In",
            Values: idValue,
          },
        ],
        Sort: [
          {
            FieldName: "Id",
            Descending: "true",
          },
        ],
      },
    }).then((response) => {
      //assertions
      assert.equal(response.body.Value[0]["CompanyId"], "100");
      assert.equal(response.body.Value[0]["CountryId"], "AT");
      assert.equal(response.body.Value[0]["Distribution"], null);
      assert.equal(response.body.Value[0]["Id"], "UFA");
      assert.equal(response.body.Value[0]["MarginschemePercent"], null);
      assert.equal(response.body.Value[0]["NonDeductibleAccountId"], null);
      assert.equal(response.body.Value[0]["Percent"], "0.00");
      assert.equal(response.body.Value[0]["ReductionTaxId"], null);
      assert.equal(response.body.Value[0]["RefId"], null);
      assert.equal(response.body.Value[0]["State"], "A");
      assert.equal(response.body.Value[0]["SummaryDeclaration"], "0");
      assert.equal(response.body.Value[0]["SuspenseAccountId"], null);
      assert.equal(response.body.Value[0]["TaxBurden"], null);
      assert.equal(response.body.Value[0]["Text1"], "Umbuchungen FA");
      assert.equal(response.body.Value[0]["Text2"], null);
      assert.equal(response.body.Value[0]["Type"], "0");
      assert.equal(response.body.Value[0]["Use"], "0");
      assert.equal(response.body.Value[0]["Zabil"], "0");

      assert.equal(response.body.Value[1]["CompanyId"], "100");
      assert.equal(response.body.Value[1]["CountryId"], "AT");
      assert.equal(response.body.Value[1]["Distribution"], 1);
      assert.equal(response.body.Value[1]["Id"], "EUZ");
      assert.equal(response.body.Value[1]["MarginschemePercent"], null);
      assert.equal(response.body.Value[1]["NonDeductibleAccountId"], null);
      assert.equal(response.body.Value[1]["Percent"], "0.00");
      assert.equal(response.body.Value[1]["ReductionTaxId"], null);
      assert.equal(response.body.Value[1]["RefId"], 2);
      assert.equal(response.body.Value[1]["State"], "A");
      assert.equal(response.body.Value[1]["SummaryDeclaration"], 0);
      assert.equal(response.body.Value[1]["SuspenseAccountId"], null);
      assert.equal(response.body.Value[1]["TaxBurden"], 0);
      assert.equal(
        response.body.Value[1]["Text1"],
        "Einfuhrumsatzsteuer Zollamt"
      );
      assert.equal(response.body.Value[1]["Text2"], null);
      assert.equal(response.body.Value[1]["Type"], "U");
      assert.equal(response.body.Value[1]["Use"], "0");
      assert.equal(response.body.Value[1]["Zabil"], 0);

      cy.log("Length: " + response.body.Value.length);
      assert.equal(response.body.Value.length, "2");
      expect(response.status).to.eq(200);
    });
  });

  //This testcase is to retrieve the get language using Greater than equal operator
  it("GetTaxCodeWithGreaterThanEqual", () => {
    var idValue = "V00";
    cy.request({
      method: "POST",
      url: `${BaseURL}TaxCodeAdministrationService.svc/json/TaxCode/TaxCodeByFilterContainer?context=${context}`,

      body: {
        Filter: [
          {
            FieldName: "Id",
            Operator: "GreaterOrEqual",
            Values: [idValue],
          },
        ],
        Sort: [
          {
            FieldName: "Id",
            Descending: "true",
          },
        ],
      },
    }).then((response) => {
      //assertions
      assert.equal(response.body.Value[0]["CompanyId"], "100");
      assert.equal(response.body.Value[0]["CountryId"], "AT");
      assert.equal(response.body.Value[0]["Distribution"], null);
      assert.equal(response.body.Value[0]["Id"], "VD");
      assert.equal(response.body.Value[0]["MarginschemePercent"], null);
      assert.equal(response.body.Value[0]["NonDeductibleAccountId"], null);
      assert.equal(response.body.Value[0]["Percent"], "0");
      assert.equal(response.body.Value[0]["ReductionTaxId"], null);
      assert.equal(response.body.Value[0]["RefId"], null);
      assert.equal(response.body.Value[0]["State"], "A");
      assert.equal(response.body.Value[0]["SummaryDeclaration"], null);
      assert.equal(response.body.Value[0]["SuspenseAccountId"], null);
      assert.equal(response.body.Value[0]["TaxBurden"], null);
      assert.equal(response.body.Value[0]["Text1"], "Vst. Direktbuchung");
      assert.equal(response.body.Value[0]["Text2"], null);
      assert.equal(response.body.Value[0]["Type"], "U");
      assert.equal(response.body.Value[0]["Use"], "0");
      assert.equal(response.body.Value[0]["Zabil"], null);

      assert.equal(response.body.Value[1]["CompanyId"], "100");
      assert.equal(response.body.Value[1]["CountryId"], "AT");
      assert.equal(response.body.Value[1]["Distribution"], null);
      assert.equal(response.body.Value[1]["Id"], "V20");
      assert.equal(response.body.Value[1]["MarginschemePercent"], null);
      assert.equal(response.body.Value[1]["NonDeductibleAccountId"], null);
      assert.equal(response.body.Value[1]["Percent"], "20");
      assert.equal(response.body.Value[1]["ReductionTaxId"], null);
      assert.equal(response.body.Value[1]["RefId"], null);
      assert.equal(response.body.Value[1]["State"], "A");
      assert.equal(response.body.Value[1]["SummaryDeclaration"], null);
      assert.equal(response.body.Value[1]["SuspenseAccountId"], null);
      assert.equal(response.body.Value[1]["TaxBurden"], null);
      assert.equal(response.body.Value[1]["Text1"], "20% Vorsteuer");
      assert.equal(response.body.Value[1]["Text2"], null);
      assert.equal(response.body.Value[1]["Type"], "V");
      assert.equal(response.body.Value[1]["Use"], "0");
      assert.equal(response.body.Value[1]["Zabil"], null);

      assert.equal(response.body.Value[2]["CompanyId"], "100");
      assert.equal(response.body.Value[2]["CountryId"], "AT");
      assert.equal(response.body.Value[2]["Distribution"], null);
      assert.equal(response.body.Value[2]["Id"], "V13");
      assert.equal(response.body.Value[2]["MarginschemePercent"], null);
      assert.equal(response.body.Value[2]["NonDeductibleAccountId"], null);
      assert.equal(response.body.Value[2]["Percent"], "13");
      assert.equal(response.body.Value[2]["ReductionTaxId"], null);
      assert.equal(response.body.Value[2]["RefId"], null);
      assert.equal(response.body.Value[2]["State"], "A");
      assert.equal(response.body.Value[2]["SummaryDeclaration"], "0");
      assert.equal(response.body.Value[2]["SuspenseAccountId"], null);
      assert.equal(response.body.Value[2]["TaxBurden"], null);
      assert.equal(response.body.Value[2]["Text1"], "13% Vorsteuer");
      assert.equal(response.body.Value[2]["Text2"], null);
      assert.equal(response.body.Value[2]["Type"], "V");
      assert.equal(response.body.Value[2]["Use"], "0");
      assert.equal(response.body.Value[2]["Zabil"], "0");

      assert.equal(response.body.Value[3]["CompanyId"], "100");
      assert.equal(response.body.Value[3]["CountryId"], "AT");
      assert.equal(response.body.Value[3]["Distribution"], null);
      assert.equal(response.body.Value[3]["Id"], "V10");
      assert.equal(response.body.Value[3]["MarginschemePercent"], null);
      assert.equal(response.body.Value[3]["NonDeductibleAccountId"], null);
      assert.equal(response.body.Value[3]["Percent"], "10");
      assert.equal(response.body.Value[3]["ReductionTaxId"], null);
      assert.equal(response.body.Value[3]["RefId"], null);
      assert.equal(response.body.Value[3]["State"], "A");
      assert.equal(response.body.Value[3]["SummaryDeclaration"], null);
      assert.equal(response.body.Value[3]["SuspenseAccountId"], null);
      assert.equal(response.body.Value[3]["TaxBurden"], null);
      assert.equal(response.body.Value[3]["Text1"], "10% Vorsteuer");
      assert.equal(response.body.Value[3]["Text2"], null);
      assert.equal(response.body.Value[3]["Type"], "V");
      assert.equal(response.body.Value[3]["Use"], "0");
      assert.equal(response.body.Value[3]["Zabil"], null);

      assert.equal(response.body.Value[4]["CompanyId"], "100");
      assert.equal(response.body.Value[4]["CountryId"], "AT");
      assert.equal(response.body.Value[4]["Distribution"], null);
      assert.equal(response.body.Value[4]["Id"], "V00");
      assert.equal(response.body.Value[4]["MarginschemePercent"], null);
      assert.equal(response.body.Value[4]["NonDeductibleAccountId"], null);
      assert.equal(response.body.Value[4]["Percent"], "0.00");
      assert.equal(response.body.Value[4]["ReductionTaxId"], null);
      assert.equal(response.body.Value[4]["RefId"], null);
      assert.equal(response.body.Value[4]["State"], "A");
      assert.equal(response.body.Value[4]["SummaryDeclaration"], null);
      assert.equal(response.body.Value[4]["SuspenseAccountId"], null);
      assert.equal(response.body.Value[4]["TaxBurden"], null);
      assert.equal(response.body.Value[4]["Text1"], "0% Vorsteuer");
      assert.equal(response.body.Value[4]["Text2"], null);
      assert.equal(response.body.Value[4]["Type"], "V");
      assert.equal(response.body.Value[4]["Use"], "0");
      assert.equal(response.body.Value[4]["Zabil"], null);

      cy.log("Length: " + response.body.Value.length);
      assert.equal(response.body.Value.length, "5");
      expect(response.status).to.eq(200);
    });
  });
});
