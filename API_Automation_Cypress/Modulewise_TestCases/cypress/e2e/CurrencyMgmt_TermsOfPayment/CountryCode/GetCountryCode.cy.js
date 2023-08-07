describe("Country Code ValIdations", () => {

    var context = '';
    var BaseURL = 'localhost:8080//api-et-basis-v1-'

it("prerequisites", () => {

        cy.login('rs', 'rsc', 'rs2', '100').then((res) => {
            context = res.body.Context;
        })
    })

    //This testcase is to retrieve the get country code 
it("GetCountryCode", () => {


        var IdValue = ["VN"]
        cy.request({
            method: "POST",
            url: `${BaseURL}CountryManagementService.svc/json/Country/CountriesByFilterContainer?context=${context}`,
            Headers: {


            },
            body: {
                "Filter": [
                    {
                        "FieldName": "Id",
                        "Operator": "Equal",
                        "Values": IdValue
                    }
                ],

            }
        }).then((response) => {

            //Assertions 
            assert.equal(response.body.Value[0]["AreaCode"], '+84')
            assert.equal(response.body.Value[0]["Description"], 'Vietnam')
            assert.equal(response.body.Value[0]["Id"], 'VN')
            assert.equal(response.body.Value[0]["Iso"], 'VN')
            assert.equal(response.body.Value[0]["Iso3166"], 'VNM')
            assert.equal(response.body.Value[0]["IsoNumeric"], '704')
            assert.equal(response.body.Value[0]["LicensePlate"], 'VN')
            assert.equal(response.body.Value[0]["CountryCodeStatistic"], null)
            assert.equal(response.body.Value[0]["CountryCodeVat"], '*')
            assert.equal(response.body.Value[0]["CustomeClearanceCode"], null)
            assert.equal(response.body.Value[0]["CustomeClearanceTyp"], null)
            assert.equal(response.body.Value[0]["CurrencyId"], null)
            assert.equal(response.body.Value[0]["RailwayTrafficCode"], null)
            assert.equal(response.body.Value[0]["Sepa"], null)
            assert.equal(response.body.Value[0]["Uid"], null)
            assert.equal(response.body.Value[0]["UidService"], null)


            //Assertions
            cy.log("Length: " + response.body.Value.length)
            assert.equal(response.body.Value.length, '1')
            expect(response.status).to.eq(200)


        })
    });

    //This testcase is to retrieve the get country code with sort
it("GetCountryCodeWithSort", () => {

    var IdValue = ["ZA"]
    cy.request({
        method: "POST",
        url: `${BaseURL}CountryManagementService.svc/json/Country/CountriesByFilterContainer?context=${context}`,
        Headers: {


        },
        body: {
            "Filter": [
                {
                    "FieldName": "Id",
                    "Operator": "GreaterOrEqual",
                    "Values": IdValue
                }
            ],
            "Sort": [
                {
                    "FieldName": "Id",
                    "Descending": "true"
                }
            ]
        }
    }).then((response) => {
        //Assertions 
        assert.equal(response.body.Value[0]["AreaCode"], '+263')
        assert.equal(response.body.Value[0]["Description"], 'Simbabwe')
        assert.equal(response.body.Value[0]["Id"], 'ZW')
        assert.equal(response.body.Value[0]["Iso"], 'ZW')
        assert.equal(response.body.Value[0]["Iso3166"], 'ZWE')
        assert.equal(response.body.Value[0]["IsoNumeric"], '716')
        assert.equal(response.body.Value[0]["LicensePlate"], 'ZW')
        assert.equal(response.body.Value[0]["CountryCodeStatistic"], null)
        assert.equal(response.body.Value[0]["CountryCodeVat"], '*')
        assert.equal(response.body.Value[0]["CustomeClearanceCode"], null)
        assert.equal(response.body.Value[0]["CustomeClearanceTyp"], null)
        assert.equal(response.body.Value[0]["CurrencyId"], null)
        assert.equal(response.body.Value[0]["RailwayTrafficCode"], null)
        assert.equal(response.body.Value[0]["Sepa"], null)
        assert.equal(response.body.Value[0]["Uid"], null)
        assert.equal(response.body.Value[0]["UidService"], null)

        assert.equal(response.body.Value[1]["AreaCode"], '+260')
        assert.equal(response.body.Value[1]["Description"], "Sambia")
        assert.equal(response.body.Value[1]["Id"], 'ZM')
        assert.equal(response.body.Value[1]["Iso"], 'ZM')
        assert.equal(response.body.Value[1]["Iso3166"], 'ZMB')
        assert.equal(response.body.Value[1]["IsoNumeric"], '894')
        assert.equal(response.body.Value[1]["LicensePlate"], 'Z')
        assert.equal(response.body.Value[1]["CountryCodeStatistic"], null)
        assert.equal(response.body.Value[1]["CountryCodeVat"], '*')
        assert.equal(response.body.Value[1]["CustomeClearanceCode"], null)
        assert.equal(response.body.Value[1]["CustomeClearanceTyp"], null)
        assert.equal(response.body.Value[1]["CurrencyId"], null)
        assert.equal(response.body.Value[1]["RailwayTrafficCode"], null)
        assert.equal(response.body.Value[1]["Sepa"], null)
        assert.equal(response.body.Value[1]["Uid"], null)
        assert.equal(response.body.Value[1]["UidService"], null)

        assert.equal(response.body.Value[2]["AreaCode"], '+27')
        assert.equal(response.body.Value[2]["Description"], "Südafrika")
        assert.equal(response.body.Value[2]["Id"], 'ZA')
        assert.equal(response.body.Value[2]["Iso"], 'ZA')
        assert.equal(response.body.Value[2]["Iso3166"], 'ZAF')
        assert.equal(response.body.Value[2]["IsoNumeric"], '710')
        assert.equal(response.body.Value[2]["LicensePlate"], 'ZA')
        assert.equal(response.body.Value[2]["CountryCodeStatistic"], null)
        assert.equal(response.body.Value[2]["CountryCodeVat"], '*')
        assert.equal(response.body.Value[2]["CustomeClearanceCode"], null)
        assert.equal(response.body.Value[2]["CustomeClearanceTyp"], null)
        assert.equal(response.body.Value[2]["CurrencyId"], null)
        assert.equal(response.body.Value[2]["RailwayTrafficCode"], null)
        assert.equal(response.body.Value[2]["Sepa"], null)
        assert.equal(response.body.Value[2]["Uid"], null)
        assert.equal(response.body.Value[2]["UidService"], null)


        //Assertions
        cy.log("Length: " + response.body.Value.length)
        assert.equal(response.body.Value.length, '3')
        expect(response.status).to.eq(200)


    })
})

//This testcase is to retrieve the get country code by passing multiple country code in value
it("GetCountryCodeWithMultipleValue", () => {

    var IdValue = ["AE", "ZW"]
    cy.request({
        method: "POST",
        url: `${BaseURL}CountryManagementService.svc/json/Country/CountriesByFilterContainer?context=${context}`,
        Headers: {


        },
        body: {
            "Filter": [
                {
                    "FieldName": "Id",
                    "Operator": "In",
                    "Values": IdValue
                }
            ],
            "Sort": [
                {
                    "FieldName": "Id",
                    "Descending": "false"
                }
            ]

        }
    }).then((response) => {

        //Assertions 
        assert.equal(response.body.Value[0]["AreaCode"], '+971')
        assert.equal(response.body.Value[0]["Description"], 'Vereinigte Arabische Emirate')
        assert.equal(response.body.Value[0]["Id"], 'AE')
        assert.equal(response.body.Value[0]["Iso"], 'AE')
        assert.equal(response.body.Value[0]["Iso3166"], 'ARE')
        assert.equal(response.body.Value[0]["IsoNumeric"], '784')
        assert.equal(response.body.Value[0]["LicensePlate"], 'UAE')
        assert.equal(response.body.Value[0]["CountryCodeStatistic"], null)
        assert.equal(response.body.Value[0]["CountryCodeVat"], '*')
        assert.equal(response.body.Value[0]["CustomeClearanceCode"], null)
        assert.equal(response.body.Value[0]["CustomeClearanceTyp"], null)
        assert.equal(response.body.Value[0]["CurrencyId"], null)
        assert.equal(response.body.Value[0]["RailwayTrafficCode"], null)
        assert.equal(response.body.Value[0]["Sepa"], null)
        assert.equal(response.body.Value[0]["Uid"], null)
        assert.equal(response.body.Value[0]["UidService"], null)

        assert.equal(response.body.Value[1]["AreaCode"], '+263')
        assert.equal(response.body.Value[1]["Description"], 'Simbabwe')
        assert.equal(response.body.Value[1]["Id"], 'ZW')
        assert.equal(response.body.Value[1]["Iso"], 'ZW')
        assert.equal(response.body.Value[1]["Iso3166"], 'ZWE')
        assert.equal(response.body.Value[1]["IsoNumeric"], '716')
        assert.equal(response.body.Value[1]["LicensePlate"], 'ZW')
        assert.equal(response.body.Value[1]["CountryCodeStatistic"], null)
        assert.equal(response.body.Value[1]["CountryCodeVat"], '*')
        assert.equal(response.body.Value[1]["CustomeClearanceCode"], null)
        assert.equal(response.body.Value[1]["CustomeClearanceTyp"], null)
        assert.equal(response.body.Value[1]["CurrencyId"], null)
        assert.equal(response.body.Value[1]["RailwayTrafficCode"], null)
        assert.equal(response.body.Value[1]["Sepa"], null)
        assert.equal(response.body.Value[1]["Uid"], null)
        assert.equal(response.body.Value[1]["UidService"], null)





        //Assertions
        cy.log("Length: " + response.body.Value.length)
        assert.equal(response.body.Value.length, '2')
        expect(response.status).to.eq(200)


    })
})

//This testcase is to retrieve the get country code using Greater than equal operator
it("GetCountryCodeWithGreaterThanEqual", () => {

    var IdValue = "ZA"
    cy.request({
        method: "POST",
        url: `${BaseURL}CountryManagementService.svc/json/Country/CountriesByFilterContainer?context=${context}`,
        Headers: {


        },
        body: {
            "Filter": [
                {
                    "FieldName": "Id",
                    "Operator": "GreaterOrEqual",
                    "Values": [IdValue]
                }
            ],
            "Sort": [
                {
                    "FieldName": "Id",
                    "Descending": "false"
                }
            ]

        }
    }).then((response) => {

        //Assertions 

        assert.equal(response.body.Value[0]["AreaCode"], '+27')
        assert.equal(response.body.Value[0]["Description"], 'Südafrika')
        assert.equal(response.body.Value[0]["Id"], 'ZA')
        assert.equal(response.body.Value[0]["Iso"], 'ZA')
        assert.equal(response.body.Value[0]["Iso3166"], 'ZAF')
        assert.equal(response.body.Value[0]["IsoNumeric"], '710')
        assert.equal(response.body.Value[0]["LicensePlate"], 'ZA')
        assert.equal(response.body.Value[0]["CountryCodeStatistic"], null)
        assert.equal(response.body.Value[0]["CountryCodeVat"], '*')
        assert.equal(response.body.Value[0]["CustomeClearanceCode"], null)
        assert.equal(response.body.Value[0]["CustomeClearanceTyp"], null)
        assert.equal(response.body.Value[0]["CurrencyId"], null)
        assert.equal(response.body.Value[0]["RailwayTrafficCode"], null)
        assert.equal(response.body.Value[0]["Sepa"], null)
        assert.equal(response.body.Value[0]["Uid"], null)
        assert.equal(response.body.Value[0]["UidService"], null)

        assert.equal(response.body.Value[1]["AreaCode"], '+260')
        assert.equal(response.body.Value[1]["Description"], 'Sambia')
        assert.equal(response.body.Value[1]["Id"], 'ZM')
        assert.equal(response.body.Value[1]["Iso"], 'ZM')
        assert.equal(response.body.Value[1]["Iso3166"], 'ZMB')
        assert.equal(response.body.Value[1]["IsoNumeric"], '894')
        assert.equal(response.body.Value[1]["LicensePlate"], 'Z')
        assert.equal(response.body.Value[1]["CountryCodeStatistic"], null)
        assert.equal(response.body.Value[1]["CountryCodeVat"], '*')
        assert.equal(response.body.Value[1]["CustomeClearanceCode"], null)
        assert.equal(response.body.Value[1]["CustomeClearanceTyp"], null)
        assert.equal(response.body.Value[1]["CurrencyId"], null)
        assert.equal(response.body.Value[1]["RailwayTrafficCode"], null)
        assert.equal(response.body.Value[1]["Sepa"], null)
        assert.equal(response.body.Value[1]["Uid"], null)
        assert.equal(response.body.Value[1]["UidService"], null)

        assert.equal(response.body.Value[2]["AreaCode"], '+263')
        assert.equal(response.body.Value[2]["Description"], 'Simbabwe')
        assert.equal(response.body.Value[2]["Id"], 'ZW')
        assert.equal(response.body.Value[2]["Iso"], 'ZW')
        assert.equal(response.body.Value[2]["Iso3166"], 'ZWE')
        assert.equal(response.body.Value[2]["IsoNumeric"], '716')
        assert.equal(response.body.Value[2]["LicensePlate"], 'ZW')
        assert.equal(response.body.Value[2]["CountryCodeStatistic"], null)
        assert.equal(response.body.Value[2]["CountryCodeVat"], '*')
        assert.equal(response.body.Value[2]["CustomeClearanceCode"], null)
        assert.equal(response.body.Value[2]["CustomeClearanceTyp"], null)
        assert.equal(response.body.Value[2]["CurrencyId"], null)
        assert.equal(response.body.Value[2]["RailwayTrafficCode"], null)
        assert.equal(response.body.Value[2]["Sepa"], null)
        assert.equal(response.body.Value[2]["Uid"], null)
        assert.equal(response.body.Value[2]["UidService"], null)





        //Assertions
        cy.log("Length: " + response.body.Value.length)
        assert.equal(response.body.Value.length, '3')
        expect(response.status).to.eq(200)


    })
})
})










