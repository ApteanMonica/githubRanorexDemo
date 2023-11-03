describe("GetAreaByAreaID", () => {

    var context = '';
    var BaseURL = 'localhost:8080//api-et-basis-v1-'
    var AreaBaseURL='localhost:8080//api-rw-fi-v1-'

it("prerequisites", () => {

        cy.login('rs', 'rsc', 'rs2', '100').then((res) => {
            context = res.body.Context;
        })
    })

    //This testcase is to verify the user is able to get a single value
it("Verify the user is able to get a single value", () => {


        var AreaID = ["3"]
        cy.request({
            method: "GET",
            url: `${AreaBaseURL}AreaService.svc/json/Area/${AreaID}/?context=${context}`,
            
        }).then((response) => {

            //Assertions 
            assert.equal(response.body.Value ["AccountLength"], null)
            assert.equal(response.body.Value ["AccrualAreaAccountId"], null)
            assert.equal(response.body.Value ["AutomaticReference"], 0)
            assert.equal(response.body.Value ["Billing"], null)
            assert.equal(response.body.Value ["CompanyId"], '100')
            assert.equal(response.body.Value ["Description"], 'Projekte')
            assert.equal(response.body.Value ["HierarchicCompanyId"], '100')
            assert.equal(response.body.Value ["Position"], 3)
            assert.equal(response.body.Value ["ProfitAccountControlId"], 'KE')
            assert.equal(response.body.Value ["Reference"], null)
            assert.equal(response.body.Value ["SettlementArea1"], 0)
            assert.equal(response.body.Value ["SettlementArea2"], 0)
            assert.equal(response.body.Value ["SettlementArea3"], 0)
            assert.equal(response.body.Value ["SettlementArea4"], 0)
            assert.equal(response.body.Value ["SettlementArea5"], 0)
            assert.equal(response.body.Value ["SettlementArea6"], 0)
            assert.equal(response.body.Value ["StockAccountControlId"], "KB")
            assert.equal(response.body.Value ["UsingId"], null)



        })
    });

 
})










