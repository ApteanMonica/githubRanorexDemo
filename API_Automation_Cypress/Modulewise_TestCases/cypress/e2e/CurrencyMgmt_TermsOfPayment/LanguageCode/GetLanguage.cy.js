describe("Language ValIdations", () => {

    var context = '';
    var BaseURL = 'localhost:8080//api-et-basis-v1-'

    it("prerequisites", () => {

        cy.login('rs', 'rsc', 'rs2', '100').then((res) => {
            context = res.body.Context;
        })
    })


    //This testcase is to retrieve the get language
    it("GetLanguage", () => {

        var idValue = "d"
        cy.request({
            method: "POST",
            url: `${BaseURL}LanguageService.svc/json/Language/LanguagesByFilterContainer?context=${context}`,
            Headers: {


            },
            body: {
                "Filter": [
                    {
                        "FieldName": "Id",
                        "Operator": "Contains",
                        "Values": [idValue]
                    }
                ]

            }

        }).then((response) => {
            //assertions
            assert.equal(response.body.Value[0]["CodePage"], null)
            assert.equal(response.body.Value[0]["Description"], "DEUTSCH")
            assert.equal(response.body.Value[0]["Id"], 'D')
            assert.equal(response.body.Value[0]["IsoCode"], 'DEU;DEA;DEC;DEL;DES')
            assert.equal(response.body.Value[0]["WindowsLanguageCode"], "DEU")



            cy.log("Length: " + response.body.Value.length)
            assert.equal(response.body.Value.length, '1')
            expect(response.status).to.eq(200)


        })
    })



    //This testcase is to retrieve the get language by passing multiple currency code values
    it("GetLanguageWithMultipleValue", () => {

        var idValue = ["E", "D"]
        cy.request({
            method: "POST",
            url: `${BaseURL}LanguageService.svc/json/Language/LanguagesByFilterContainer?context=${context}`,
            Headers: {


            },
            body: {
                "Filter": [
                    {
                        "FieldName": "Id",
                        "Operator": "In",
                        "Values": idValue
                    }

                ]
            }

        }).then((response) => {
            //assertions
            assert.equal(response.body.Value[0]["CodePage"], null)
            assert.equal(response.body.Value[0]["Description"], "DEUTSCH")
            assert.equal(response.body.Value[0]["Id"], 'D')
            assert.equal(response.body.Value[0]["IsoCode"], 'DEU;DEA;DEC;DEL;DES')
            assert.equal(response.body.Value[0]["WindowsLanguageCode"], "DEU")

            assert.equal(response.body.Value[1]["CodePage"], null)
            assert.equal(response.body.Value[1]["Description"], "ENGLISCH")
            assert.equal(response.body.Value[1]["Id"], 'E')
            assert.equal(response.body.Value[1]["IsoCode"], 'ENG;ENU')
            assert.equal(response.body.Value[1]["WindowsLanguageCode"], "ENG")



            cy.log("Length: " + response.body.Value.length)
            assert.equal(response.body.Value.length, '2')
            expect(response.status).to.eq(200)


        })
    })


    //This testcase is to retrieve the get language using sort
    it("GetLanguageWithSort", () => {

        var idValue = ["E", "D"]
        cy.request({
            method: "POST",
            url: `${BaseURL}LanguageService.svc/json/Language/LanguagesByFilterContainer?context=${context}`,
            Headers: {


            },
            body: {
                "Filter": [
                    {
                        "FieldName": "Id",
                        "Operator": "In",
                        "Values": idValue
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
            //assertions

            assert.equal(response.body.Value[0]["CodePage"], null)
            assert.equal(response.body.Value[0]["Description"], "ENGLISCH")
            assert.equal(response.body.Value[0]["Id"], 'E')
            assert.equal(response.body.Value[0]["IsoCode"], 'ENG;ENU')
            assert.equal(response.body.Value[0]["WindowsLanguageCode"], "ENG")

            assert.equal(response.body.Value[1]["CodePage"], null)
            assert.equal(response.body.Value[1]["Description"], "DEUTSCH")
            assert.equal(response.body.Value[1]["Id"], 'D')
            assert.equal(response.body.Value[1]["IsoCode"], 'DEU;DEA;DEC;DEL;DES')
            assert.equal(response.body.Value[1]["WindowsLanguageCode"], "DEU")





            cy.log("Length: " + response.body.Value.length)
            assert.equal(response.body.Value.length, '2')
            expect(response.status).to.eq(200)


        })
    })

    //This testcase is to retrieve the get language using Greater than equal operator
    it("GetLanguageWithGreaterThanEqual", () => {

        var idValue = "d"
        cy.request({
            method: "POST",
            url: `${BaseURL}LanguageService.svc/json/Language/LanguagesByFilterContainer?context=${context}`,
            Headers: {


            },
            body: {
                "Filter": [
                    {
                        "FieldName": "Id",
                        "Operator": "GreaterOrEqual",
                        "Values": [idValue]
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

            //assertions
            assert.equal(response.body.Value[0]["CodePage"], null)
            assert.equal(response.body.Value[0]["Description"], "KANNADA")
            assert.equal(response.body.Value[0]["Id"], 'K')
            assert.equal(response.body.Value[0]["IsoCode"], 'KAN')
            assert.equal(response.body.Value[0]["WindowsLanguageCode"], "KAN")

            assert.equal(response.body.Value[1]["CodePage"], null)
            assert.equal(response.body.Value[1]["Description"], "HINDI")
            assert.equal(response.body.Value[1]["Id"], 'H')
            assert.equal(response.body.Value[1]["IsoCode"], 'HIN')
            assert.equal(response.body.Value[1]["WindowsLanguageCode"], "HIN")

            assert.equal(response.body.Value[2]["CodePage"], null)
            assert.equal(response.body.Value[2]["Description"], "FRENCH")
            assert.equal(response.body.Value[2]["Id"], 'F')
            assert.equal(response.body.Value[2]["IsoCode"], 'FRE')
            assert.equal(response.body.Value[2]["WindowsLanguageCode"], "FRE")

            assert.equal(response.body.Value[3]["CodePage"], null)
            assert.equal(response.body.Value[3]["Description"], "ENGLISCH")
            assert.equal(response.body.Value[3]["Id"], 'E')
            assert.equal(response.body.Value[3]["IsoCode"], 'ENG;ENU')
            assert.equal(response.body.Value[3]["WindowsLanguageCode"], "ENG")

            assert.equal(response.body.Value[4]["CodePage"], null)
            assert.equal(response.body.Value[4]["Description"], "DEUTSCH")
            assert.equal(response.body.Value[4]["Id"], 'D')
            assert.equal(response.body.Value[4]["IsoCode"], 'DEU;DEA;DEC;DEL;DES')
            assert.equal(response.body.Value[4]["WindowsLanguageCode"], "DEU")


            cy.log("Length: " + response.body.Value.length)
            assert.equal(response.body.Value.length, '5')
            expect(response.status).to.eq(200)


        })
    })
})