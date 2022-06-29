# Peer Coding Assignment
## _Introduction_

This API will connect to a databases of sports teams across various leagues. This assignement does not have many hard set rules, except that the below routes are created by the interviewer. Feel free to create data transfer models for returning data if needed. Endpoints created should be demonstrated as working through Swagger, Postman, or a similar tool. Database has been preseeded with data, GUID identifiers can be provided to the interviewer on request

## Routes To Build

```
An endpoint that returns a league and all of the teams within that league
GET api/league/{leagueId:guid}
```
```
An endpoint that adds a team to the data store. Be sure to include a league, 
POST api/team/
```

```
An endpoint that gets all teams within a division, 
GET api/division/
```

```
An endpoint that updates a team, 
PUT api/team/
```