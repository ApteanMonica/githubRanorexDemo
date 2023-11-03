describe("Terms of payment Validations", () => {

    var context = '';
    var BaseURL = 'localhost:8080//'

    /**
     * This it block is used to generate the context using login credentials which will be used in further it blocks
     */
    it("prerequisites",()=>
    {
      
    cy.login('rs', 'rsc', 'rs2', '100').then((res) => {
        context = res.body.Context;  
    })})


    /** 
     * This it block is used to get the list of "Terms of payment and its details"
    */
    it("GetTermsOfPaymentList", () => {        
        cy.request({
            method: "GET",
            url: `${BaseURL}api-rw-fi-v1-TermsOfPaymentService.svc/json/TermsOfPayment/TermsOfPayments?context=${context}`,
            

        }).then((response) => {
            //assertions
            assert.equal(response.body.Value[0]["CashDiscountPct1"],2)
            assert.equal(response.body.Value[0]["CashDiscountPct2"], 3)
            assert.equal(response.body.Value[0]["CashDiscountPeriod1"], 14)
            assert.equal(response.body.Value[0]["CashDiscountPeriod2"], 15)
            assert.equal(response.body.Value[0]["ChangeStates"], '0')            
            assert.equal(response.body.Value[0]["Code"], '001')
            assert.equal(response.body.Value[0]["DayUntilInvoiceDate"], '1')
            assert.equal(response.body.Value[0]["DefinableField1"], null)
            assert.equal(response.body.Value[0]["DefinableField2"], null)
            assert.equal(response.body.Value[0]["DefinableField3"], null)
            assert.equal(response.body.Value[0]["DefinableField4"], null)
            assert.equal(response.body.Value[0]["DefinableField5"], null)
            assert.equal(response.body.Value[0]["Description"], '14 Tage 2%, 30 Tage netto')
            assert.equal(response.body.Value[0]["Edi"], '0')
            assert.equal(response.body.Value[0]["NetDays"], '30')
            assert.equal(response.body.Value[0]["State"], '0')
            assert.equal(response.body.Value[0]["Ultimo"], null)
            assert.equal(response.body.Value[0]["ValutaDate"],null)
            assert.equal(response.body.Value[0]["ValutaDays"], null)           
            
            assert.equal(response.body.Value[1]["CashDiscountPct1"],1)
            assert.equal(response.body.Value[1]["CashDiscountPct2"], null)
            assert.equal(response.body.Value[1]["CashDiscountPeriod1"], 6)
            assert.equal(response.body.Value[1]["CashDiscountPeriod2"], null)
            assert.equal(response.body.Value[1]["ChangeStates"], '1')            
            assert.equal(response.body.Value[1]["Code"], '030')
            assert.equal(response.body.Value[1]["DayUntilInvoiceDate"], '0')
            assert.equal(response.body.Value[1]["DefinableField1"], null)
            assert.equal(response.body.Value[1]["DefinableField2"], null)
            assert.equal(response.body.Value[1]["DefinableField3"], null)
            assert.equal(response.body.Value[1]["DefinableField4"], null)
            assert.equal(response.body.Value[1]["DefinableField5"], null)
            assert.equal(response.body.Value[1]["Description"], '30 Tage netto')
            assert.equal(response.body.Value[1]["Edi"], '0')
            assert.equal(response.body.Value[1]["NetDays"], '30')
            assert.equal(response.body.Value[1]["State"], '0')
            assert.equal(response.body.Value[1]["Ultimo"], null)
            assert.equal(response.body.Value[1]["ValutaDate"], null)
            assert.equal(response.body.Value[1]["ValutaDays"], null)

            assert.equal(response.body.Value[2]["CashDiscountPct1"],4)
            assert.equal(response.body.Value[2]["CashDiscountPct2"], 3)
            assert.equal(response.body.Value[2]["CashDiscountPeriod1"], 2)
            assert.equal(response.body.Value[2]["CashDiscountPeriod2"], 17)
            assert.equal(response.body.Value[2]["ChangeStates"], '1')            
            assert.equal(response.body.Value[2]["Code"], '031')
            assert.equal(response.body.Value[2]["DayUntilInvoiceDate"], '1')
            assert.equal(response.body.Value[2]["DefinableField1"], null)
            assert.equal(response.body.Value[2]["DefinableField2"], null)
            assert.equal(response.body.Value[2]["DefinableField3"], null)
            assert.equal(response.body.Value[2]["DefinableField4"], null)
            assert.equal(response.body.Value[2]["DefinableField5"], null)
            assert.equal(response.body.Value[2]["Description"], "Updating DayUntilInvoiceDate")
            assert.equal(response.body.Value[2]["Edi"], '0')
            assert.equal(response.body.Value[2]["NetDays"], '30')
            assert.equal(response.body.Value[2]["State"], '9')
            assert.equal(response.body.Value[2]["Ultimo"], null)
            assert.equal(response.body.Value[2]["ValutaDate"], null)
            assert.equal(response.body.Value[2]["ValutaDays"], null)

            assert.equal(response.body.Value[3]["CashDiscountPct1"],45)
            assert.equal(response.body.Value[3]["CashDiscountPct2"], null)
            assert.equal(response.body.Value[3]["CashDiscountPeriod1"], 2)
            assert.equal(response.body.Value[3]["CashDiscountPeriod2"], null)
            assert.equal(response.body.Value[3]["ChangeStates"], '1')            
            assert.equal(response.body.Value[3]["Code"], '032')
            assert.equal(response.body.Value[3]["DayUntilInvoiceDate"], '0')
            assert.equal(response.body.Value[3]["DefinableField1"], null)
            assert.equal(response.body.Value[3]["DefinableField2"], null)
            assert.equal(response.body.Value[3]["DefinableField3"], null)
            assert.equal(response.body.Value[3]["DefinableField4"], null)
            assert.equal(response.body.Value[3]["DefinableField5"], null)
            assert.equal(response.body.Value[3]["Description"], '30 Tage netto')
            assert.equal(response.body.Value[3]["Edi"], '0')
            assert.equal(response.body.Value[3]["NetDays"], '30')
            assert.equal(response.body.Value[3]["State"], '9')
            assert.equal(response.body.Value[3]["Ultimo"], null)
            assert.equal(response.body.Value[3]["ValutaDate"], null)
            assert.equal(response.body.Value[3]["ValutaDays"], null)

            assert.equal(response.body.Value[4]["CashDiscountPct1"],2)
            assert.equal(response.body.Value[4]["CashDiscountPct2"], 2)
            assert.equal(response.body.Value[4]["CashDiscountPeriod1"], 1)
            assert.equal(response.body.Value[4]["CashDiscountPeriod2"], 9)
            assert.equal(response.body.Value[4]["ChangeStates"], '1')            
            assert.equal(response.body.Value[4]["Code"], '045')
            assert.equal(response.body.Value[4]["DayUntilInvoiceDate"], '0')
            assert.equal(response.body.Value[4]["DefinableField1"], null)
            assert.equal(response.body.Value[4]["DefinableField2"], null)
            assert.equal(response.body.Value[4]["DefinableField3"], null)
            assert.equal(response.body.Value[4]["DefinableField4"], null)
            assert.equal(response.body.Value[4]["DefinableField5"], null)
            assert.equal(response.body.Value[4]["Description"], null)
            assert.equal(response.body.Value[4]["Edi"], '0')
            assert.equal(response.body.Value[4]["NetDays"], '31')
            assert.equal(response.body.Value[4]["State"], '1')
            assert.equal(response.body.Value[4]["Ultimo"], null)
            assert.equal(response.body.Value[4]["ValutaDate"], null)
            assert.equal(response.body.Value[4]["ValutaDays"], null)

            expect(response.status).to.eq(200)
           

        })
    })
           
})