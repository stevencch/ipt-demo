import { rest, setupWorker } from 'msw'
import { Proposal } from '../types/proposals/Proposal'

const ARTIFICIAL_DELAY_MS = 1000

const proposals: Proposal[] = [
    {
       proposalId:1,
       proposalName:"proposal1",
       customerGrpName:"CustomerGrpName1",
       date:new Date(2022,5,1),
       description:"Detailed description1",
       status:"In Preparation",
       facilities:[
          {
             facilityId:1,
             facilityName:"Facility1",
             country:"Australia",
             currency:"AUD",
             startDate:new Date(2022,5,1),
             maturityDate:new Date(2022,5,1),
             limit:1000000000
          },
          {
            facilityId:2,
            facilityName:"Facility2",
            country:"Australia",
            currency:"AUD",
            startDate:new Date(2022,5,1),
            maturityDate:new Date(2022,5,1),
            limit:1000000000
         },
       ]
    },
    {
        proposalId:2,
        proposalName:"proposal2",
        customerGrpName:"CustomerGrpName2",
        date:new Date(2022,5,1),
        description:"Detailed description2",
        status:"In Preparation",
        facilities:[]
    }
 ]

export const handlers = [

  rest.get('/api/proposal/getData', (req, res, ctx) => {
    return res(
      ctx.delay(ARTIFICIAL_DELAY_MS),
      ctx.json(proposals)
    )
  }),
]

export const worker = setupWorker(...handlers)