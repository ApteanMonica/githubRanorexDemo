describe("Get terms of payment text Validations", () => {

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
     * This it block is used to verify the user is able to get all terms of payment with valid filter Column by the search filter
    */
    it("GetTermsOfPaymentTextWithValidFilter", () => {
        cy.request({
            method: "POST",
            url: `${BaseURL}TermsOfPaymentService.svc/json/TermsOfPaymentText/TermsOfPaymentTextBySearchFilter?context=${context}`,
            Headers: {

            },
            body: {

                "Filter": "D",
                "filterColumn": 0,
                "From": "001",
                "To": "030"
            }

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

            expect(response.status).to.eq(200)


        })
    })

    /** 
     * This it block is used to verify the user is not able to get all  terms of payment  with invalid filterColumn by the search  filter
    */
    it("GetTermsOfPaymentTextWithInvalidFilter", () => {
        cy.request({
            method: "POST",
            url: `${BaseURL}TermsOfPaymentService.svc/json/TermsOfPaymentText/TermsOfPaymentTextBySearchFilter?context=${context}`,
            Headers: {

            },
            body: {

                "Filter": "D",
                "filterColumn": 4,
                "From": "001",
                "To": "030"
            }

        }).then((response) => {
            //assertions
            assert.equal(response.body.Messages[0]["Id"], "rssoft.common.message.ArgumentInvalidError")
            //"The argument searchFilter is invalid: "
            assert.equal(response.body.Messages[0]["Text"], "The argument searchFilter is invalid: ")
            expect(response.status).to.eq(200)


        })
    })


    /** 
     * This it block is used to verify the user is able to get terms of payment by search  filter "TO" in body
    */
    it("GetTermsOfPaymentTextByOnlyGivingToFilter", () => {
        cy.request({
            method: "POST",
            url: `${BaseURL}TermsOfPaymentService.svc/json/TermsOfPaymentText/TermsOfPaymentTextBySearchFilter?context=${context}`,
            Headers: {

            },
            body: {

                "Filter": "E",
                "filterColumn": 0,
                "To": "030"
            }

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
     * This it block is used to verify the user is able to get terms of payment by search  filter "From" in body
    */
    it("GetTermsOfPaymentTextByOnlyGivingFromFilter", () => {
        cy.request({
            method: "POST",
            url: `${BaseURL}TermsOfPaymentService.svc/json/TermsOfPaymentText/TermsOfPaymentTextBySearchFilter?context=${context}`,
            Headers: {

            },
            body: {

                "Filter": "E",
                "filterColumn": 0,
                "From": "001"
            }

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
     * This it block is used to verify if the user is not able to get Terms of payment text when passing the request with empty object
    */
    it("GetTermsOfPaymentTextByPassingEmptyBody", () => {
        cy.request({
            method: "POST",
            url: `${BaseURL}TermsOfPaymentService.svc/json/TermsOfPaymentText/TermsOfPaymentTextBySearchFilter?context=${context}`,
            Headers: {

            },
            body: {
            }

        }).then((response) => {
            //asserstions
            assert.equal(response.body.Value[0]["Code"], '001')
            assert.equal(response.body.Value[0]["Description"], "API TEST FOR UPDATE 143")
            assert.equal(response.body.Value[0]["Language"], "D")
            assert.equal(response.body.Value[0]["LanguagePackageImport"], null)

            //assertions
            assert.equal(response.body.Value[1]["Code"], '001')
            assert.equal(response.body.Value[1]["Description"], "14 days 2%, 30 days net")
            assert.equal(response.body.Value[1]["Language"], "E")
            assert.equal(response.body.Value[1]["LanguagePackageImport"], null)

            //assertions
            assert.equal(response.body.Value[2]["Code"], '030')
            assert.equal(response.body.Value[2]["Description"], "30 Tage netto")
            assert.equal(response.body.Value[2]["Language"], "D")
            assert.equal(response.body.Value[2]["LanguagePackageImport"], null)

            //assertions
            assert.equal(response.body.Value[3]["Code"], '030')
            assert.equal(response.body.Value[3]["Description"], "30 days net")
            assert.equal(response.body.Value[3]["Language"], "E")
            assert.equal(response.body.Value[3]["LanguagePackageImport"], null)

            //assertions
            assert.equal(response.body.Value[4]["Code"], '031')
            assert.equal(response.body.Value[4]["Description"], "erfwe")
            assert.equal(response.body.Value[4]["Language"], "D")
            assert.equal(response.body.Value[4]["LanguagePackageImport"], null)

            expect(response.status).to.eq(200)


        })
    })



})