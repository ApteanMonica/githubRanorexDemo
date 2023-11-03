describe("GetExchangeTypes", () => {

    var context = '';
    var BaseURL = 'localhost:8080//api-rw-fi-v1-'

    it("prerequisites", () => {

        cy.login('rs', 'rsc', 'rs2', '100').then((res) => {
            context = res.body.Context;
        })
    })


    //This testcase is to verify the user is able to get exchange rate type
    it("Verify the user is able to get exchange rate types", () => {

        cy.request({
            method: "GET",
            url: `${BaseURL}CurrencyService.svc/json/Currency/TypesOfExchangeRate?context=${context}`,
            

        }).then((response) => {
            //assertions
            assert.equal(response.body.Value[0]["Description"], "BRIEFKURS")
            assert.equal(response.body.Value[0]["Id"], "B")

            assert.equal(response.body.Value[1]["Description"], "GELDKURS")
            assert.equal(response.body.Value[1]["Id"], "G")

            assert.equal(response.body.Value[2]["Description"], "MITTELKURS")
            assert.equal(response.body.Value[2]["Id"], "M")

            assert.equal(response.body.Value[3]["Description"], "VERRECHNUNGSKURS")
            assert.equal(response.body.Value[3]["Id"], "V")

            assert.equal(response.body.Value[4]["Description"], "ZKMANDA")
            assert.equal(response.body.Value[4]["Id"], "Z")



            cy.log("Length: " + response.body.Value.length)
            assert.equal(response.body.Value.length, '5')
            expect(response.status).to.eq(200)


        })
    })

})