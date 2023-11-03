describe("Terms of payment Validations", () => {

    //Parameters used to Terms of payment code 
    var context = '';
    var BaseURL = 'localhost:8080//api-rw-fi-v1-'
    var code = Math.floor(Math.random() * 1000)
    var state = 0
    var netDays = 30
    var description = "API Automation"
    var valutaDate = "2023-01-01T00:00:00"
    var cashDiscountPeriod1 = 11
    var cashDiscountPct1 = 2.00
    var cashDiscountPeriod2 = 21
    var cashDiscountPct2 = 1.00
    var edi = 1
    var changeState = 0

    /**
     * This it block is used to generate the context using login credentials which will be used in further it blocks
     */
    it("prerequisites", () => {

        cy.login('rs', 'rsc', 'rs2', '100').then((res) => {
            context = res.body.Context;
        })
    })


    /**
     * This it block is used to create new terms of payment and validate the response
     */
    it("createTermsOfPayment", () => {


        cy.request({
            method: "POST",
            url: `${BaseURL}TermsOfPaymentService.svc/json/TermsOfPayment?context=${context}`,
            
            body: {
                "Code": code,
                "State": state,
                "CashDiscountPeriod1": cashDiscountPeriod1,
                "CashDiscountPct1": cashDiscountPct1,
                "NetDays": netDays,
                "CashDiscountPeriod2": cashDiscountPeriod2,
                "CashDiscountPct2": cashDiscountPct2,
                "Description": description,
                "ChangeStates": changeState,
                "Edi": edi,
                "ValutaDate": valutaDate
            }

        }).then((response) => {
            //assertions
            assert.equal(response.body.Value["CashDiscountPct1"], cashDiscountPct1)
            assert.equal(response.body.Value["CashDiscountPct2"], cashDiscountPct2)
            assert.equal(response.body.Value["CashDiscountPeriod1"], cashDiscountPeriod1)
            assert.equal(response.body.Value["CashDiscountPeriod2"], cashDiscountPeriod2)
            assert.equal(response.body.Value["ChangeStates"], changeState)
            assert.equal(response.body.Value["Code"], code)
            assert.equal(response.body.Value["DayUntilInvoiceDate"], '0')
            assert.equal(response.body.Value["DefinableField1"], null)
            assert.equal(response.body.Value["DefinableField2"], null)
            assert.equal(response.body.Value["DefinableField3"], null)
            assert.equal(response.body.Value["DefinableField4"], null)
            assert.equal(response.body.Value["DefinableField5"], null)
            assert.equal(response.body.Value["Description"], description)
            assert.equal(response.body.Value["Edi"], edi)
            assert.equal(response.body.Value["NetDays"], netDays)
            assert.equal(response.body.Value["State"], state)
            assert.equal(response.body.Value["Ultimo"], null)
            assert.equal(response.body.Value["ValutaDate"], valutaDate)
            assert.equal(response.body.Value["ValutaDays"], null)

            expect(response.status).to.eq(200)


        })
    })

    /**
     * This it block is used to update the existing terms of payment code and validate the response
     */
    it("updateTermsOfPayment", () => {

        var updateState = 9
        var updateDescription = "Updated description"
        cy.request({
            method: "PUT",
            url: `${BaseURL}TermsOfPaymentService.svc/json/TermsOfPayment?context=${context}`,
           
            body: {
                "Code": code,
                "State": updateState,
                "CashDiscountPeriod1": 11,
                "CashDiscountPct1": 2.00,
                "NetDays": 30,
                "CashDiscountPeriod2": 21,
                "CashDiscountPct2": 1.00,
                "Description": updateDescription,
                "ChangeStates": 1,
                "Edi": "1"
            }

        }).then((response) => {
            //assertions
            assert.equal(response.body.Value["CashDiscountPct1"], cashDiscountPct1)
            assert.equal(response.body.Value["CashDiscountPct2"], cashDiscountPct2)
            assert.equal(response.body.Value["CashDiscountPeriod1"], cashDiscountPeriod1)
            assert.equal(response.body.Value["CashDiscountPeriod2"], cashDiscountPeriod2)
            assert.equal(response.body.Value["ChangeStates"], '1')
            assert.equal(response.body.Value["Code"], code)
            assert.equal(response.body.Value["DayUntilInvoiceDate"], '0')
            assert.equal(response.body.Value["DefinableField1"], null)
            assert.equal(response.body.Value["DefinableField2"], null)
            assert.equal(response.body.Value["DefinableField3"], null)
            assert.equal(response.body.Value["DefinableField4"], null)
            assert.equal(response.body.Value["DefinableField5"], null)
            assert.equal(response.body.Value["Description"], updateDescription)
            assert.equal(response.body.Value["Edi"], edi)
            assert.equal(response.body.Value["NetDays"], netDays)
            assert.equal(response.body.Value["State"], updateState)
            assert.equal(response.body.Value["Ultimo"], null)
            assert.equal(response.body.Value["ValutaDate"], null)
            assert.equal(response.body.Value["ValutaDays"], null)

            expect(response.status).to.eq(200)


        })
    })

    /**
     * This it block is used  delete the existing terms of payment code and to validate the deleted code by get method
     */
    it("deleteTermsOfPayment", () => {

        
            cy.request({
            method: "DELETE",
            url: `${BaseURL}TermsOfPaymentService.svc/json/TermsOfPayment/${code}?context=${context}`,
            

        }).then((response) => {
            //assertions
            expect(response.status).to.eq(200)


        })

        cy.request({
            method: "GET",
            url: `${BaseURL}TermsOfPaymentService.svc/json/TermsOfPayment/${code}?context=${context}`,
            

        }).then((response) => {
            //assertions
            assert.equal(response.body.Messages[0]["Id"],"rssoft.common.message.DataNotFoundError")   
            assert.equal(response.body.Messages[0]["Text"],"No TermsOfPayment could be found! ")        
            
            expect(response.status).to.eq(200)
    })

})

})