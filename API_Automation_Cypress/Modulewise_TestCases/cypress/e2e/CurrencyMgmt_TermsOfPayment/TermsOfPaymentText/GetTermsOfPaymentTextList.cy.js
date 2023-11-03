describe("Get Terms of payment Text List", () => {

    var context = '';
    var BaseURL = 'localhost:8080//api-rw-fi-v1-'

    /**
     * This it block is used to generate the context using login credentials which will be used in further it blocks
     */
    it("prerequisites", () => {

        cy.login('rs', 'rsc', 'rs2', '100').then((res) => {
            context = res.body.Context;
        })
    })


    /** 
     * This it block is used to verify the user can get all the terms of payment with language "D"
    */
    it("GetTermsOfPaymentTextForLanguage:D", () => {
        var termsOfPaymentTextCode = 'D'
        cy.request({
            method: "GET",
            url: `${BaseURL}TermsOfPaymentService.svc/json/TermsOfPayment/${termsOfPaymentTextCode}/TermsOfPaymentText?context=${context}`,
            

        }).then((response) => {
            //assertions
            assert.equal(response.body.Value[0]["Code"], '001')
            assert.equal(response.body.Value[0]["Description"], "API TEST FOR UPDATE 143")
            assert.equal(response.body.Value[0]["Language"], "D")
            assert.equal(response.body.Value[0]["LanguagePackageImport"], null)

            //assertions
            assert.equal(response.body.Value[1]["Code"], '030')
            assert.equal(response.body.Value[1]["Description"], "30 Tage netto")
            assert.equal(response.body.Value[1]["Language"], "D")
            assert.equal(response.body.Value[1]["LanguagePackageImport"], null)

            //assertions
            assert.equal(response.body.Value[2]["Code"], '031')
            assert.equal(response.body.Value[2]["Description"], "erfwe")
            assert.equal(response.body.Value[2]["Language"], "D")
            assert.equal(response.body.Value[2]["LanguagePackageImport"], null)

            //assertions
            assert.equal(response.body.Value[3]["Code"], '032')
            assert.equal(response.body.Value[3]["Description"], "43432")
            assert.equal(response.body.Value[3]["Language"], "D")
            assert.equal(response.body.Value[3]["LanguagePackageImport"], null)

            //assertions
            assert.equal(response.body.Value[4]["Code"], '045')
            assert.equal(response.body.Value[4]["Description"], "132123")
            assert.equal(response.body.Value[4]["Language"], "D")
            assert.equal(response.body.Value[4]["LanguagePackageImport"], null)


            expect(response.status).to.eq(200)


        })
    })


    /** 
     * This it block is used to verify the user can get all the terms of payment with language "E"
    */
    it("GetTermsOfPaymentTextForLanguage:E", () => {
        var termsOfPaymentTextCode = 'E'
        cy.request({
            method: "GET",
            url: `${BaseURL}TermsOfPaymentService.svc/json/TermsOfPayment/${termsOfPaymentTextCode}/TermsOfPaymentText?context=${context}`,
            

        }).then((response) => {
            //assertions
            assert.equal(response.body.Value[0]["Code"], '001')
            assert.equal(response.body.Value[0]["Description"], "14 days 2%, 30 days net")
            assert.equal(response.body.Value[0]["Language"], "E")
            assert.equal(response.body.Value[0]["LanguagePackageImport"], null)

            //assertions
            assert.equal(response.body.Value[1]["Code"], '030')
            assert.equal(response.body.Value[1]["Description"], "30 days net")
            assert.equal(response.body.Value[1]["Language"], "E")
            assert.equal(response.body.Value[1]["LanguagePackageImport"], null)

            expect(response.status).to.eq(200)


        })
    })

   

    /** 
     * This it block is used to verify the user not get terms of payment text with invalid context
    */
    it("GetTermsOfPaymentTextWithInvalidContext", () => {
        var invalidContext = "ASJKSBJKSDBKVBKBVBDSVFVKJDBVKSD"
        var termsOfPaymentTextCode = 'E'
        cy.request({
            method: "GET",
            url: `${BaseURL}TermsOfPaymentService.svc/json/TermsOfPayment/${termsOfPaymentTextCode}/TermsOfPaymentText?context=${invalidContext}`,
            

        }).then((response) => {
            //assertions
            assert.equal(response.body.Messages[0]["Id"], "rssoft.common.rs2.authentication.InvalidContextValueError")
            //"The specified login context (ASJKSBJKSDBKVBKBVBDSVFVKJDBVKSD) is invalid"
            assert.equal(response.body.Messages[0]["Text"], "Der angegebene Anmelde-Context (ASJKSBJKSDBKVBKBVBDSVFVKJDBVKSD) ist ungültig")
            expect(response.status).to.eq(200)


        })
    })


})