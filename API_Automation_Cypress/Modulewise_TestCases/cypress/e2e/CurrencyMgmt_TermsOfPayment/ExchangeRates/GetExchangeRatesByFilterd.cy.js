describe("Language ValIdations", () => {

    var context = '';
    var BaseURL = 'localhost:8080//api-rw-fi-v1-'

    it("prerequisites", () => {

        cy.login('rs', 'rsc', 'rs2', '100').then((res) => {
            context = res.body.Context;
        })
    })


    //This testcase is to verify the user is able to get value by the search  filter
    it("Verify the user is able to get value by the search  filter", () => {

        cy.request({
            method: "POST",
            url: `${BaseURL}CurrencyService.svc/json/Currency/ExchangeRatesByFilterContainer?context=${context}`,
           
            body: {
                "Filter" : [
                    {
                        "FieldName" : "ExchangeRateTypeId",
                        "Operator" : "Equal",
                        "Values" : [
                            "M"
                        ]
                    },
                    {
                        "FieldName" : "Date",
                        "Operator" : "Equal",
                        "Values" : [
                            "2023-10-26T00:00:00"
                        ]
                    }
                ],
                "Sort": [
                    {
                        "FieldName" : "CurrencyId",
                        "Descending" : "true"
                    }
                ],
            }
                
            })

          .then((response) => {
            //assertions
            assert.equal(response.body.Value[0]["BaseCurrency"], "12.0000000000")
            assert.equal(response.body.Value[0]["CompanyId"], "100")
            assert.equal(response.body.Value[0]["CurrencyId"], "AED")
            assert.equal(response.body.Value[0]["Date"], "2023-10-26T00:00:00")
            assert.equal(response.body.Value[0]["ExchangeRateTypeId"], "M")
            assert.equal(response.body.Value[0]["ForeignCurrency"], "0.0833333333")


            cy.log("Length: " + response.body.Value.length)
            assert.equal(response.body.Value.length, '1')
            expect(response.status).to.eq(200)


        })
    
    })

})

