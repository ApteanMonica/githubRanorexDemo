describe("Create terms of payment text validations", () => {

    //Parameters used to Terms of payment text 
    var context = ""
    var BaseURL = 'localhost:8080//api-rw-fi-v1-'
    var languageCode = 'E'
    var termsOfPaymentCode = 100
    var description = "API Automation"
    var Length

    /**
     * This it block is used to generate the context using login credentials which will be used in further it blocks
     */
    it("prerequisites", () => {

        cy.login('rs', 'rsc', 'rs2', '100').then((res) => {
            context = res.body.Context;

        })
    })


    /**
     * This it block is used to verify user is able to create Terms of payment text by passing correct values in the request 
     */
    it("createTermsOfPaymentText", () => {


        cy.request({
            method: "POST",
            url: `${BaseURL}TermsOfPaymentService.svc/json/TermsOfPayment/${termsOfPaymentCode}/TermsOfPaymentText?context=${context}`,
            
            body:
            {
                "Language": languageCode,
                "Description": description
            }

        }).then((response) => {
            //assertions
            assert.equal(response.body.Value["Code"], termsOfPaymentCode)
            assert.equal(response.body.Value["Language"], languageCode)
            assert.equal(response.body.Value["Description"], description)
            expect(response.status).to.eq(200)


        })
    })

    /**
    * This it block is used to verify user is not able to create Terms of payment text by passing already created values in the request 
    */
    it("createTermsOfPaymentTextWithExistingCode", () => {


        cy.request({
            method: "POST",
            url: `${BaseURL}TermsOfPaymentService.svc/json/TermsOfPayment/${termsOfPaymentCode}/TermsOfPaymentText?context=${context}`,
            
            body:
            {
                "Language": languageCode,
                "Description": description
            }

        }).then((response) => {
            //assertions
            assert.equal(response.body.Messages[0]["Id"], "rssoft.bfw.rw.fi.serv.TermsOfPaymentAlreadyExistsError")
            //"Payment terms already exist!"
            assert.equal(response.body.Messages[0]["Text"], "Zahlungsbedingungen sind bereits vorhanden!")
            expect(response.status).to.eq(200)

        })
    })

    /**
     * This it block is used to verify the user is not able to create Terms of payment text by passing blank in mandatory fields request 
     */
    it("createTermsOfPaymentTextByPassingMandatoryValueEmpty", () => {


        cy.request({
            method: "POST",
            url: `${BaseURL}TermsOfPaymentService.svc/json/TermsOfPayment/${termsOfPaymentCode}/TermsOfPaymentText?context=${context}`,
            
            body:
            {
                "Language": "",
                "Description": description
            }

        }).then((response) => {
            //assertions
            assert.equal(response.body.Messages[0]["Id"], "rssoft.common.message.ParameterNullOrEmptyError")
            //"The value of the parameter 'SPRA_CD' was not found or not entered"
            assert.equal(response.body.Messages[0]["Text"], "Der Wert des Parameters 'SPRA_CD' wurde nicht gefunden oder nicht eingegeben")
            expect(response.status).to.eq(200)

        })
    })

    /**
    * This it block is used to verify user is able to create Terms of payment text by passing incorrect value in code
    */
    it("createTermsOfPaymentTextByPassingInvalidTermsOfPaymentCode", () => {


        cy.request({
            method: "POST",
            url: `${BaseURL}TermsOfPaymentService.svc/json/TermsOfPayment/invalidtermsOfPaymentCode/TermsOfPaymentText?context=${context}`,
            
            body:
            {
                "Language": languageCode,
                "Description": description
            }

        }).then((response) => {
            //assertions
            assert.equal(response.body.Messages[0]["Id"], "rssoft.bfw.rw.fi.serv.TermsOfPaymentNotExistsError")
            //"There is no payment term text for the specified payment term code"
            assert.equal(response.body.Messages[0]["Text"], "Für den angegebenen Zahlungsbedingungscode existiert kein Zahlungsbedingungstext")
            expect(response.status).to.eq(200)


        })
    })

    /**
     * This it block is used to verify user is able to create Terms of payment text by passing incorrect values in language
     */
    it("createTermsOfPaymentTextByPassinInvalidLanguage", () => {


        cy.request({
            method: "POST",
            url: `${BaseURL}TermsOfPaymentService.svc/json/TermsOfPayment/${termsOfPaymentCode}/TermsOfPaymentText?context=${context}`,
            
            body:
            {
                "Language": "Z",
                "Description": description
            }

        }).then((response) => {
            //assertions
            assert.equal(response.body.Messages[0]["Id"], "rssoft.bfw.rw.fi.serv.LanguageCodeNotExistsError")
            //"There is no payment terms text set for the specified language code!"
            assert.equal(response.body.Messages[0]["Text"], "Für den angegebenen Sprachcode existiert kein Zahlungsbedingungen-Textsatz!")
            expect(response.status).to.eq(200)

        })
    })

    /**
   * This it block is used to verify if the user is not able to create Terms of payment text when passing the request with empty object
   */
    it("createTermsOfPaymentTextByPassingEmptyBody", () => {


        cy.request({
            method: "POST",
            url: `${BaseURL}TermsOfPaymentService.svc/json/TermsOfPayment/${termsOfPaymentCode}/TermsOfPaymentText?context=${context}`,
            
            body:
            {
            }

        }).then((response) => {
            //assertions
            assert.equal(response.body.Messages[0]["Id"], "rssoft.common.message.ParameterNullOrEmptyError")
            //"The value of the parameter 'SPRA_CD' was not found or not entered"
            assert.equal(response.body.Messages[0]["Text"], "Der Wert des Parameters 'SPRA_CD' wurde nicht gefunden oder nicht eingegeben")

            assert.equal(response.body.Messages[1]["Id"], "rssoft.common.message.ParameterNullOrEmptyError")
            //"The value of the parameter 'ZLTX_BEZ' was not found or not entered"
            assert.equal(response.body.Messages[1]["Text"], "Der Wert des Parameters 'ZLTX_BEZ' wurde nicht gefunden oder nicht eingegeben")
            expect(response.status).to.eq(200)

        })
    })

    /**
    * This it block is used to verify if the user is not able to create Terms of payment text when passing the request with null object
    */
    it("createTermsOfPaymentTextByPassingNullValuesInBody", () => {


        cy.request({
            method: "POST",
            url: `${BaseURL}TermsOfPaymentService.svc/json/TermsOfPayment/${termsOfPaymentCode}/TermsOfPaymentText?context=${context}`,
            
            body:
            {
                "Language": null,
                "Description": null
            }

        }).then((response) => {
            //assertions
            assert.equal(response.body.Messages[0]["Id"], "rssoft.common.message.ParameterNullOrEmptyError")
            //"The value of the parameter 'SPRA_CD' was not found or not entered"
            assert.equal(response.body.Messages[0]["Text"], "Der Wert des Parameters 'SPRA_CD' wurde nicht gefunden oder nicht eingegeben")

            assert.equal(response.body.Messages[1]["Id"], "rssoft.common.message.ParameterNullOrEmptyError")
            //"The value of the parameter 'ZLTX_BEZ' was not found or not entered"
            assert.equal(response.body.Messages[1]["Text"], "Der Wert des Parameters 'ZLTX_BEZ' wurde nicht gefunden oder nicht eingegeben")
            expect(response.status).to.eq(200)

        })
    })

    /**
     * This it block is used to verify the user did not create terms of payment text with an invalid context
     */
    it("createTermsOfPaymentTextByPassingInvalidContext", () => {


        cy.request({
            method: "POST",
            url: `${BaseURL}TermsOfPaymentService.svc/json/TermsOfPayment/${termsOfPaymentCode}/TermsOfPaymentText?context=invalidcontext`,
            
            body:
            {
                "Language": null,
                "Description": null
            }

        }).then((response) => {
            //assertions
            assert.equal(response.body.Messages[0]["Id"], "rssoft.common.rs2.authentication.InvalidContextValueError")
            //"The specified login context (invalidcontext) is invalid"
            assert.equal(response.body.Messages[0]["Text"], "Der angegebene Anmelde-Context (invalidcontext) ist ungültig")
            expect(response.status).to.eq(200)

        })
    })

     /**
    * This it block is used to verify if the user not having the permission to Update a terms of payment text, can not update a Terms of payment text
    */
     var context2 = ""
     var updateDescription="Test Description"

     it("CreateTermsOfPaymentTextWithUnauthorizedUser", () => {
 
         cy.login('TEST', 'rsc', 'rs2', '200').then((res) => {
             context2 = res.body.Context;
             cy.log(context2)
 
         }).then(() => {
            cy.request({
                method: "POST",
                url: `${BaseURL}TermsOfPaymentService.svc/json/TermsOfPayment/${termsOfPaymentCode}/TermsOfPaymentText?context=${context2}`,
                
                body:
                {
                    "Language": languageCode,
                    "Description": description
                }
    
            }).then((response) => {
                 //assertions
                 assert.equal(response.body.Messages[0]["Id"], "rssoft.bfw.common.AccessDeniedError")
                 //"Access denied - To access this resource, you need the following right: API-RW-FI-TERMSOFPAYMENTSERVICE / *!"
                 assert.equal(response.body.Messages[0]["Text"], "Access denied - To access this resource, you need the following right: API-RW-FI-TERMSOFPAYMENTSERVICE / *!")
                 expect(response.status).to.eq(200)
 
             })
         })
     })


    /**
       * This it block is used to verify the user is not able to delete terms of payment text with invalid terms of payment code and valid language Code
       */
    it("deleteTermsOfPaymentWithInvalidTermsOfPaymentCode", () => {

        var invalidTermsOfPaymentCode = 5683935

        cy.request({
            method: "DELETE",
            url: `${BaseURL}TermsOfPaymentService.svc/json/TermsOfPayment/${invalidTermsOfPaymentCode}/TermsOfPaymentText?languageCode=${languageCode}&context=${context}`,
            

        }).then((response) => {
            //assertions
            assert.equal(response.body.Messages[0]["Id"], "rssoft.common.message.DataNotFoundError")
            //"No TermsOfPaymentText could be found! "
            assert.equal(response.body.Messages[0]["Text"], "No TermsOfPaymentText could be found! ")
            expect(response.status).to.eq(200)

        })
    })
    /**
      * This it block is used to verify the user is not able to delete terms of payment text with valid terms of payment code and invalid language Code
      */
    it("deleteTermsOfPaymentWithInvalidLanguageCode", () => {

        var invalidLanguageCode = 'p'

        cy.request({
            method: "DELETE",
            url: `${BaseURL}TermsOfPaymentService.svc/json/TermsOfPayment/${termsOfPaymentCode}/TermsOfPaymentText?languageCode=${invalidLanguageCode}&context=${context}`,
            

        }).then((response) => {
            //assertions
            assert.equal(response.body.Messages[0]["Id"], "rssoft.common.message.DataNotFoundError")
            //"No TermsOfPaymentText could be found! "
            assert.equal(response.body.Messages[0]["Text"], "No TermsOfPaymentText could be found! ")
            expect(response.status).to.eq(200)

        })
    })

    /**
       * This it block is used to verify  the user is not able to delete terms of payment text with invalid termsOfPaymentCode and invalid languageCode
       */
    it("deleteTermsOfPaymentWithInvalidTermsOfPaymentCodeAndLanguageCode", () => {

        var invalidLanguageCode = 'p'
        var invalidTermsOfPaymentCode = 5683935

        cy.request({
            method: "DELETE",
            url: `${BaseURL}TermsOfPaymentService.svc/json/TermsOfPayment/${invalidTermsOfPaymentCode}/TermsOfPaymentText?languageCode=${invalidLanguageCode}&context=${context}`,
            

        }).then((response) => {
            //assertions
            assert.equal(response.body.Messages[0]["Id"], "rssoft.common.message.DataNotFoundError")
            //"No TermsOfPaymentText could be found! "
            assert.equal(response.body.Messages[0]["Text"], "No TermsOfPaymentText could be found! ")
            expect(response.status).to.eq(200)

        })
    })

    /**
     * This it block is used to verify the user not delete terms of payment text with invalid context 
     */
    it("deleteTermsOfPaymentWhichHasAlredayBeenDeleted", () => {

        var invalidContext = "BNDSBCSADJCJWDVCDVCLDBCWLDBC"
        cy.request({
            method: "DELETE",
            url: `${BaseURL}TermsOfPaymentService.svc/json/TermsOfPayment/${termsOfPaymentCode}/TermsOfPaymentText?languageCode=${languageCode}&context=${invalidContext}`,
            

        }).then((response) => {
            //assertions
            assert.equal(response.body.Messages[0]["Id"], "rssoft.common.rs2.authentication.InvalidContextValueError")
            //"The specified login context (BNDSBCSADJCJWDVCDVCLDBCWLDBC) is invalid"
            assert.equal(response.body.Messages[0]["Text"], "Der angegebene Anmelde-Context (BNDSBCSADJCJWDVCDVCLDBCWLDBC) ist ungültig")
            expect(response.status).to.eq(200)

        })
    })



    /**
     * This it block is used to verify  the user is able to delete terms of payment text with valid terms of payment code and valid language Code
     */
    it("deleteTermsOfPayment", () => {


        cy.request({
            method: "DELETE",
            url: `${BaseURL}TermsOfPaymentService.svc/json/TermsOfPayment/${termsOfPaymentCode}/TermsOfPaymentText?languageCode=${languageCode}&context=${context}`,
            

        }).then((response) => {
            //assertions
            expect(response.status).to.eq(200)

        })

        cy.request({
            method: "GET",
            url: `${BaseURL}TermsOfPaymentService.svc/json/TermsOfPayment/${languageCode}/TermsOfPaymentText?context=${context}`,
            

        }).then((response) => {
            //assertions
            Length = response.body.Value.length
            console.log(Length)

            for (var i = 0; i <= Length - 1; i++) {

                try {
                    if (response.body.Value[i]["Code"] == termsOfPaymentCode) {
                        throw new Error("Terms of paymnet text exist")
                    }

                } catch (e) {

                    console.error(e)
                }

            }
            // assert.equal(response.body.Messages[0]["Id"],"rssoft.common.message.DataNotFoundError")   
            // assert.equal(response.body.Messages[0]["Text"],"No TermsOfPayment could be found! ")        

            expect(response.status).to.eq(200)
        })

    })


    /**
    * This it block is used to verify the user got a proper valid message for already deleted terms of payment text
    */
    it("deleteTermsOfPaymentWhichHasAlredayBeenDeleted", () => {


        cy.request({
            method: "DELETE",
            url: `${BaseURL}TermsOfPaymentService.svc/json/TermsOfPayment/${termsOfPaymentCode}/TermsOfPaymentText?languageCode=${languageCode}&context=${context}`,
            

        }).then((response) => {
            //assertions
            assert.equal(response.body.Messages[0]["Id"], "rssoft.common.message.DataNotFoundError")
            //"No TermsOfPaymentText could be found! "
            assert.equal(response.body.Messages[0]["Text"], "No TermsOfPaymentText could be found! ")
            expect(response.status).to.eq(200)

        })
    })

    /**
    * This it block is used to verify if the user not having the permission to Delete a terms of payment text, can not delete a Terms of payment text
    */
    var context2 = ""

    it("DeleteOfPaymentCodeWithUnauthorizedUser", () => {

        cy.login('TEST', 'rsc', 'rs2', '200').then((res) => {
            context2 = res.body.Context;
            cy.log(context2)

        }).then(() => {
            cy.request({
                method: "DELETE",
                url: `${BaseURL}TermsOfPaymentService.svc/json/TermsOfPayment/${termsOfPaymentCode}/TermsOfPaymentText?languageCode=${languageCode}&context=${context2}`,
                

            }).then((response) => {
                //assertions
                assert.equal(response.body.Messages[0]["Id"], "rssoft.bfw.common.AccessDeniedError")
                //"Access denied - To access this resource, you need the following right: API-RW-FI-TERMSOFPAYMENTSERVICE / *!"
                assert.equal(response.body.Messages[0]["Text"], "Access denied - To access this resource, you need the following right: API-RW-FI-TERMSOFPAYMENTSERVICE / *!")
                expect(response.status).to.eq(200)

            })
        })
    })




})

