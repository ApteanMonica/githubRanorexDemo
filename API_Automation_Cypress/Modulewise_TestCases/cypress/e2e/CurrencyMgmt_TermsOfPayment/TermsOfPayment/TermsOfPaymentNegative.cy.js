describe("Terms of payment Validations Negative", () => {


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
     * This it method is used to create the terms of payment by passing empty parameters in the code
     */
    it("createTermsOfPaymentWithEmptyParameters", () => {


        var code = ""

        cy.request({
            method: "POST",
            url: `${BaseURL}TermsOfPaymentService.svc/json/TermsOfPayment?context=${context}`,
            Headers: {

            },
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
            assert.equal(response.body.Messages[0]["Id"], "rssoft.common.message.ParameterNullOrEmptyError")
            //The value of the parameter 'ZLBD_CD' was not found or not entered
            assert.equal(response.body.Messages[0]["Text"], "Der Wert des Parameters 'ZLBD_CD' wurde nicht gefunden oder nicht eingegeben")
            expect(response.status).to.eq(200)
            cy.screenshot()


        })

    })


    /**
    //  * This it method is used to validate creatation of terms of payment by passing cash discount peroid 2 greater than cash discount peroid 1 
     */
    it("createTermsOfPaymentWithCashDiscountPeriod2GreaterThanCashDiscountPeriod2", () => {

        var cashDiscountPeriod1 = 20
        var cashDiscountPeriod2 = 10
        cy.request({
            method: "POST",
            url: `${BaseURL}TermsOfPaymentService.svc/json/TermsOfPayment?context=${context}`,
            Headers: {

            },
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
            assert.equal(response.body.Messages[0]["Id"], "rssoft.bfw.rw.fi.serv.DiscountPeriod2LessThanDiscountPeriod1Error")
            //"The discount period2 must last longer than the discount period1"
            assert.equal(response.body.Messages[0]["Text"], "Die Skontofrist2 muss länger dauern als die Skontofrist1")


            expect(response.status).to.eq(200)


        })
    })

    /**
    //  * This it method is used to validate creatation of terms of payment by passing cash discount peroid 2 greater than net days
     */
    it("createTermsOfPaymentWithCashDiscountPeriod2GreaterThanNetDays", () => {

        var cashDiscountPeriod1 = 3
        var cashDiscountPeriod2 = 20
        var netDays = 10
        cy.request({
            method: "POST",
            url: `${BaseURL}TermsOfPaymentService.svc/json/TermsOfPayment?context=${context}`,
            Headers: {

            },
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
            assert.equal(response.body.Messages[0]["Id"], "rssoft.bfw.rw.fi.serv.NetDaysAreLessThanDiscountPeriod2Error")
            //The value of the parameter 'ZLBD_CD' was not found or not entered
            assert.equal(response.body.Messages[0]["Text"], "Die Nettofrist muss mindestenst so lange sein wie die Skontofrist2!")

            expect(response.status).to.eq(200)


        })
    })

    /**
     * This it method is used to update the terms of payment by passing code with more than three characters
     */
    it("createTermsOfPaymentCodeWithMoreThanThreeCharacters", () => {

        var code = 12345;

        cy.request({
            method: "POST",
            url: `${BaseURL}TermsOfPaymentService.svc/json/TermsOfPayment?context=${context}`,
            Headers: {

            },
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
            assert.equal(response.body.Messages[0]["Id"], "rssoft.bfw.common.repository.EntityValidationMaxLengthError")
            //"The value of the parameter 'ZLBD_CD' was not found or not entered"
            assert.equal(response.body.Messages[0]["Text"], "The contents of the property S_ZLBD.ZLBD_CD is longer than 3 characters!")

            expect(response.status).to.eq(200)


        })
    })


    /**
     * This it method is used to update the terms of payment by passing existing terms of payment code
     */
    it("createTermsOfPaymentCodeWithExistingCode", () => {

        var code = '1@0';

        cy.request({
            method: "POST",
            url: `${BaseURL}TermsOfPaymentService.svc/json/TermsOfPayment?context=${context}`,
            Headers: {

            },
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
            assert.equal(response.body.Messages[0]["Id"], "rssoft.bfw.rw.fi.serv.TermsOfPaymentAlreadyExistsError")
            //"Payment terms already exist!"
            assert.equal(response.body.Messages[0]["Text"], "Zahlungsbedingungen sind bereits vorhanden!")

            expect(response.status).to.eq(200)


        })
    })


    /**
         * This it block is used to validate business logic
         * */
    it("createTermsOfPayment_BusinessLogic", () => {

        /**
     * This it block is used to validate
     * 1)Discount percentage if discount is peroid is specified
     * 2)The discount period 1 is less than or equal to net days
     * 3)Create an terms of payment by passing cash discount peroid 1 and without net days 
     */
        var code = 221
        cy.request({
            method: "POST",
            url: `${BaseURL}TermsOfPaymentService.svc/json/TermsOfPayment?context=${context}`,
            Headers: {

            },
            body: {
                "Code": code,
                "State": state,
                "CashDiscountPeriod1": cashDiscountPeriod1,
                // "CashDiscountPct1": cashDiscountPct1,
                // "NetDays": netDays,
                // "CashDiscountPeriod2": cashDiscountPeriod2,
                // "CashDiscountPct2": cashDiscountPct2,
                // "Description": description,
                // "ChangeStates": changeState,
                // "Edi": edi,
                // "ValutaDate": valutaDate
            }

        }).then((response) => {
            //assertions
            assert.equal(response.body.Messages[0]["Id"], "rssoft.bfw.rw.fi.serv.DiscountDeductionNotSpecifiedError")
            //If a discount period has been specified, a discount deduction must also be specified as a percentage!
            assert.equal(response.body.Messages[0]["Text"], "Wenn eine Skontofrist angegeben worden ist, muss auch ein Skontoabzug in Prozent angeben werden!")

            assert.equal(response.body.Messages[1]["Id"], "rssoft.bfw.rw.fi.serv.NetDaysCannotBeEmptyError")
            //Enter the deadline for the net days. (The period of the net days must be longer or the same as the discount period1)
            assert.equal(response.body.Messages[1]["Text"], "Geben sie die Frist für die Netto-Tage an. (Frist der Netto-Tage muss länger bzw. gleich lang dauern wie Skontofrist1)")

            assert.equal(response.body.Messages[2]["Id"], "rssoft.bfw.rw.fi.serv.NetDaysAreLessThanDiscountPeriod1Error")
            //The net period must be at least as long as the discount period1!
            assert.equal(response.body.Messages[2]["Text"], "Die Nettofrist muss mindestenst so lange dauern wie Skontofrist1!")
            expect(response.status).to.eq(200)

        })

        /**
         * This it block is used to validate
         * 1)The discount period 1 is less than or equal to net days
         * 2)Create an terms of payment by passing cash discount peroid 1, cash discount pct 1 and without net days 
         * */
        var code = 221
        cy.request({
            method: "POST",
            url: `${BaseURL}TermsOfPaymentService.svc/json/TermsOfPayment?context=${context}`,
            Headers: {

            },
            body: {
                "Code": code,
                "State": state,
                "CashDiscountPeriod1": cashDiscountPeriod1,
                "CashDiscountPct1": cashDiscountPct1,
                // "NetDays": netDays,
                // "CashDiscountPeriod2": cashDiscountPeriod2,
                // "CashDiscountPct2": cashDiscountPct2,
                // "Description": description,
                // "ChangeStates": changeState,
                // "Edi": edi,
                // "ValutaDate": valutaDate
            }

        }).then((response) => {
            //assertions
            assert.equal(response.body.Messages[0]["Id"], "rssoft.bfw.rw.fi.serv.NetDaysCannotBeEmptyError")
            //Enter the deadline for the net days. (The period of the net days must be longer or the same as the discount period1)
            assert.equal(response.body.Messages[0]["Text"], "Geben sie die Frist für die Netto-Tage an. (Frist der Netto-Tage muss länger bzw. gleich lang dauern wie Skontofrist1)")

            assert.equal(response.body.Messages[1]["Id"], "rssoft.bfw.rw.fi.serv.NetDaysAreLessThanDiscountPeriod1Error")
            //The net period must be at least as long as the discount period1!
            assert.equal(response.body.Messages[1]["Text"], "Die Nettofrist muss mindestenst so lange dauern wie Skontofrist1!")
            expect(response.status).to.eq(200)

        })

        /**
         * This it block is used to validate
         * 1)The discount period 1, discount percentage 1, discount period 2 and net days are given without discount percentage 2.
         * */
        var code = 221
        cy.request({
            method: "POST",
            url: `${BaseURL}TermsOfPaymentService.svc/json/TermsOfPayment?context=${context}`,
            Headers: {

            },
            body: {
                "Code": code,
                "State": state,
                "CashDiscountPeriod1": cashDiscountPeriod1,
                "CashDiscountPct1": cashDiscountPct1,
                "NetDays": netDays,
                "CashDiscountPeriod2": cashDiscountPeriod2,
                // "CashDiscountPct2": cashDiscountPct2,
                // "Description": description,
                // "ChangeStates": changeState,
                // "Edi": edi,
                // "ValutaDate": valutaDate
            }

        }).then((response) => {
            //assertions
            assert.equal(response.body.Messages[0]["Id"], "rssoft.bfw.rw.fi.serv.DiscountDeductionNotSpecifiedError")
            //"If a discount period has been specified, a discount deduction must also be specified as a percentage!"
            assert.equal(response.body.Messages[0]["Text"], "Wenn eine Skontofrist angegeben worden ist, muss auch ein Skontoabzug in Prozent angeben werden!")

        })

        /**
         * This it block is used to validate
         * 1)The discount period 1, discount percentage 1, discount period 2 and net days are given without discount percentage 2.
         * */
        var code = 221
        cy.request({
            method: "POST",
            url: `${BaseURL}TermsOfPaymentService.svc/json/TermsOfPayment?context=${context}`,
            Headers: {

            },
            body: {
                "Code": code,
                "State": state,
                "CashDiscountPeriod1": cashDiscountPeriod1,
                "CashDiscountPct1": cashDiscountPct1,
                // "NetDays": netDays,
                "CashDiscountPeriod2": cashDiscountPeriod2,
                "CashDiscountPct2": cashDiscountPct2,
                // "Description": description,
                // "ChangeStates": changeState,
                // "Edi": edi,
                // "ValutaDate": valutaDate
            }

        }).then((response) => {
            //assertions
            assert.equal(response.body.Messages[0]["Id"], "rssoft.bfw.rw.fi.serv.NetDaysCannotBeEmptyError")
            //"Enter the deadline for the net days. (The period of the net days must be longer or the same as the discount period1)"
            assert.equal(response.body.Messages[0]["Text"], "Geben sie die Frist für die Netto-Tage an. (Frist der Netto-Tage muss länger bzw. gleich lang dauern wie Skontofrist1)")

            assert.equal(response.body.Messages[1]["Id"], "rssoft.bfw.rw.fi.serv.NetDaysAreLessThanDiscountPeriod2Error")
            //"The net period must be at least as long as the discount period2!"
            assert.equal(response.body.Messages[1]["Text"], "Die Nettofrist muss mindestenst so lange sein wie die Skontofrist2!")
        })

    })


    /**
     * This it method is used to update the terms of payment with invalid status code
     */
    it("updateTermsOfPaymentWithInvalidStatusCode", () => {

        var code = '1@0'
        var updateState = 560
        var updateDescription = "Updated description"
        cy.request({
            method: "PUT",
            url: `${BaseURL}TermsOfPaymentService.svc/json/TermsOfPayment?context=${context}`,
            Headers: {

            },
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
            assert.equal(response.body.Messages[0]["Id"], "rssoft.common.message.DoesNotExistsError")
            //"Payment terms already exist!"
            assert.equal(response.body.Messages[0]["Text"], "Status 560 in ZLBD_STATUS does not exist!")

            expect(response.status).to.eq(200)


        })
    })


    /**
     * This it method is used to update the terms of payment by passing empty parameters in the code
     */
    it("updateTermsOfPaymentWithEmptyCode", () => {

        var code = ''
        var updateState = 560
        var updateDescription = "Updated description"
        cy.request({
            method: "PUT",
            url: `${BaseURL}TermsOfPaymentService.svc/json/TermsOfPayment?context=${context}`,
            Headers: {

            },
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
            assert.equal(response.body.Messages[0]["Id"], "rssoft.common.message.ParameterNullOrEmptyError")
            //"The value of the parameter 'ZLBD_CD' was not found or not entered"
            assert.equal(response.body.Messages[0]["Text"], "Der Wert des Parameters 'ZLBD_CD' wurde nicht gefunden oder nicht eingegeben")

            expect(response.status).to.eq(200)


        })
    })

})