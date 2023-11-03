describe("Currency Code ValIdations", () => {

    var context = '';
    var BaseURL = 'localhost:8080//api-rw-fi-v1-'

    it("prerequisites",()=>
    {
      
    cy.login('rs', 'rsc', 'rs2', '100').then((res) => {
        context = res.body.Context;  
    })})

    //This testcase is to retrieve the get currency code 
    it("GetCurrencyCode", () => {

        var IdValue ="AED"
        cy.request({
            method: "POST",
            url: `${BaseURL}CurrencyService.svc/json/Currency/CurrenciesByFilterContainer?context=${context}`,
            body: {
                "Filter" : [
                    {
                        "FieldName" : "Id",                        
                        "Operator" : "In",
                        "Values" : [
                            IdValue
                        ]
                    }
                ],
               
            }

        }).then((response) => {           
            
            //assertions
            assert.equal(response.body.Value[0]["CurrencyKey1"], null)
            assert.equal(response.body.Value[0]["CurrencyKey2"] , null)
            assert.equal(response.body.Value[0]["DecimalTax"], '2')
            assert.equal(response.body.Value[0]["DecimalCurrency"], '2')
            assert.equal(response.body.Value[0]["DeletionDate"], null)
            assert.equal(response.body.Value[0]["Description"], 'Dirham')
            assert.equal( response.body.Value[0]["EuroDate"], null)
            assert.equal(response.body.Value[0]["EuroRate"], null)
            assert.equal(response.body.Value[0]["Id"], 'AED')
            assert.equal(response.body.Value[0]["IsoCode"], 'AED')            
            

            cy.log("Length: " + response.body.Value.length)
            assert.equal(response.body.Value.length, '1')
            expect(response.status).to.eq(200)
           

        })
    })


    //This testcase is to retrieve the get currency code using Sort
    it("GetCurrencyCodeWithSort", () => {

        var IdValue =["AED","YER"]
        cy.request({
            method: "POST",
            url: `${BaseURL}CurrencyService.svc/json/Currency/CurrenciesByFilterContainer?context=${context}`,

            body: {
                "Filter" : [
                    {
                        "FieldName" : "Id",                        
                        "Operator" : "In",
                        "Values" : IdValue
                        
                    }
                ],
                "Sort": [
                    {
                        "FieldName" : "Id",
                        "Descending" : "true"
                    }
                ]
            }

        }).then((response) => {

            //assertions

            assert.equal(response.body.Value[0]["CurrencyKey1"], null)
            assert.equal(response.body.Value[0]["CurrencyKey2"] , null)
            assert.equal(response.body.Value[0]["DecimalTax"], '2')
            assert.equal(response.body.Value[0]["DecimalCurrency"], '2')
            assert.equal(response.body.Value[0]["DeletionDate"], null)
            assert.equal(response.body.Value[0]["Description"], 'Jemen-Rial')
            assert.equal( response.body.Value[0]["EuroDate"], null)
            assert.equal(response.body.Value[0]["EuroRate"], null)
            assert.equal(response.body.Value[0]["Id"], 'YER')
            assert.equal(response.body.Value[0]["IsoCode"], 'YER')

            assert.equal(response.body.Value[1]["CurrencyKey1"], null)
            assert.equal(response.body.Value[1]["CurrencyKey2"] , null)
            assert.equal(response.body.Value[1]["DecimalTax"], '2')
            assert.equal(response.body.Value[1]["DecimalCurrency"], '2')
            assert.equal(response.body.Value[1]["DeletionDate"], null)
            assert.equal(response.body.Value[1]["Description"], 'Dirham')
            assert.equal( response.body.Value[1]["EuroDate"], null)
            assert.equal(response.body.Value[1]["EuroRate"], null)
            assert.equal(response.body.Value[1]["Id"], 'AED')
            assert.equal(response.body.Value[1]["IsoCode"], 'AED')     
            
            

            cy.log("Length: " + response.body.Value.length)
            assert.equal(response.body.Value.length, '2')
            expect(response.status).to.eq(200)
           

        })
    })


    //This testcase is to retrieve the get currency code by passing multiple currency code values
    it("GetCurrencyCodeWithMultipleValue", () => {

        var IdValue =["AED","INR"]
        cy.request({
            method: "POST",
            url: `${BaseURL}CurrencyService.svc/json/Currency/CurrenciesByFilterContainer?context=${context}`,

            body: {
                "Filter" : [
                    {
                        "FieldName" : "Id",                        
                        "Operator" : "In",
                        "Values" : IdValue                                           
                    }
                ],
                "Sort": [
                    {
                        "FieldName" : "Id",
                        "Descending" : "true"
                    }
                ]
            }

        }).then((response) => {
            //assertions

            assert.equal(response.body.Value[0]["CurrencyKey1"], null)
            assert.equal(response.body.Value[0]["CurrencyKey2"] , null)
            assert.equal(response.body.Value[0]["DecimalTax"], '2')
            assert.equal(response.body.Value[0]["DecimalCurrency"], '2')
            assert.equal(response.body.Value[0]["DeletionDate"], null)
            assert.equal(response.body.Value[0]["Description"], 'Indische Rupie')
            assert.equal( response.body.Value[0]["EuroDate"], null)
            assert.equal(response.body.Value[0]["EuroRate"], null)
            assert.equal(response.body.Value[0]["Id"], 'INR')
            assert.equal(response.body.Value[0]["IsoCode"], 'INR')


            assert.equal(response.body.Value[1]["CurrencyKey1"], null)
            assert.equal(response.body.Value[1]["CurrencyKey2"] , null)
            assert.equal(response.body.Value[1]["DecimalTax"], '2')
            assert.equal(response.body.Value[1]["DecimalCurrency"], '2')
            assert.equal(response.body.Value[1]["DeletionDate"], null)
            assert.equal(response.body.Value[1]["Description"], 'Dirham')
            assert.equal( response.body.Value[1]["EuroDate"], null)
            assert.equal(response.body.Value[1]["EuroRate"], null)
            assert.equal(response.body.Value[1]["Id"], 'AED')
            assert.equal(response.body.Value[1]["IsoCode"], 'AED')   
            

            cy.log("Length: " + response.body.Value.length)
            assert.equal(response.body.Value.length, '2')
            expect(response.status).to.eq(200)
           

        })
    })


    //This testcase is to retrieve the get currency code using Greater than equal operator
    it("GetCurrencyCodeWithGreaterThanEqual", () => {

        var IdValue ="XPF"
        cy.request({
            method: "POST",
            url: `${BaseURL}CurrencyService.svc/json/Currency/CurrenciesByFilterContainer?context=${context}`,
            body: {
                "Filter" : [
                    {
                        "FieldName" : "Id",                        
                        "Operator": "GreaterOrEqual",
                        "Values" : [IdValue]                                           
                    }
                ],
                "Sort": [
                    {
                        "FieldName" : "Id",
                        "Descending" : "true"
                    }
                ]
            }

        }).then((response) => {         
            //assertions

            assert.equal(response.body.Value[0]["CurrencyKey1"], null)
            assert.equal(response.body.Value[0]["CurrencyKey2"] , null)
            assert.equal(response.body.Value[0]["DecimalTax"], '2')
            assert.equal(response.body.Value[0]["DecimalCurrency"], '2')
            assert.equal(response.body.Value[0]["DeletionDate"], null)
            assert.equal(response.body.Value[0]["Description"], 'Simbabwe-Dollar')
            assert.equal( response.body.Value[0]["EuroDate"], null)
            assert.equal(response.body.Value[0]["EuroRate"], null)
            assert.equal(response.body.Value[0]["Id"], 'ZWD')
            assert.equal(response.body.Value[0]["IsoCode"], 'ZWD')

            assert.equal(response.body.Value[1]["CurrencyKey1"], null)
            assert.equal(response.body.Value[1]["CurrencyKey2"] , null)
            assert.equal(response.body.Value[1]["DecimalTax"], '2')
            assert.equal(response.body.Value[1]["DecimalCurrency"], '2')
            assert.equal(response.body.Value[1]["DeletionDate"], null)
            assert.equal(response.body.Value[1]["Description"], 'Kwacha')
            assert.equal( response.body.Value[1]["EuroDate"], null)
            assert.equal(response.body.Value[1]["EuroRate"], null)
            assert.equal(response.body.Value[1]["Id"], 'ZMK')
            assert.equal(response.body.Value[1]["IsoCode"], null)

            assert.equal(response.body.Value[2]["CurrencyKey1"], null)
            assert.equal(response.body.Value[2]["CurrencyKey2"] , null)
            assert.equal(response.body.Value[2]["DecimalTax"], '2')
            assert.equal(response.body.Value[2]["DecimalCurrency"], '2')
            assert.equal(response.body.Value[2]["DeletionDate"], null)
            assert.equal(response.body.Value[2]["Description"], 'Rand')
            assert.equal( response.body.Value[2]["EuroDate"], null)
            assert.equal(response.body.Value[2]["EuroRate"], null)
            assert.equal(response.body.Value[2]["Id"], 'ZAR')
            assert.equal(response.body.Value[2]["IsoCode"], 'ZAR')
            
            
            assert.equal(response.body.Value[3]["CurrencyKey1"], null)
            assert.equal(response.body.Value[3]["CurrencyKey2"] , null)
            assert.equal(response.body.Value[3]["DecimalTax"], '2')
            assert.equal(response.body.Value[3]["DecimalCurrency"], '2')
            assert.equal(response.body.Value[3]["DeletionDate"], null)
            assert.equal(response.body.Value[3]["Description"], 'Jemen-Rial')
            assert.equal( response.body.Value[3]["EuroDate"], null)
            assert.equal(response.body.Value[3]["EuroRate"], null)
            assert.equal(response.body.Value[3]["Id"], 'YER')
            assert.equal(response.body.Value[3]["IsoCode"], 'YER')

            assert.equal(response.body.Value[4]["CurrencyKey1"], null)
            assert.equal(response.body.Value[4]["CurrencyKey2"] , null)
            assert.equal(response.body.Value[4]["DecimalTax"], '2')
            assert.equal(response.body.Value[4]["DecimalCurrency"], '2')
            assert.equal(response.body.Value[4]["DeletionDate"], null)
            assert.equal(response.body.Value[4]["Description"], 'CFP-Franc')
            assert.equal( response.body.Value[4]["EuroDate"], null)
            assert.equal(response.body.Value[4]["EuroRate"], null)
            assert.equal(response.body.Value[4]["Id"], 'XPF')
            assert.equal(response.body.Value[4]["IsoCode"], 'XPF')

           

            

            
            
            

            cy.log("Length: " + response.body.Value.length)
            assert.equal(response.body.Value.length, '5')
            expect(response.status).to.eq(200)
           

        })
    })
})