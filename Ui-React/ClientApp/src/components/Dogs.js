import React, { Component } from 'react';

export class Dogs extends Component {
    displayName = Dogs.name;

    render() {
        const robsDogs = {
        ownerName: 'Rob',
        dogNames: ['Willow', 'Nook', 'Sox']
        };

        //check that array has elements
        if (robsDogs.dogNames.length > 0) {
            return (
                <div>
                    <h1>Hello, {robsDogs.ownerName}!</h1>
                    <h5>You have the following dog(s):</h5>
                    <ol>
                        {robsDogs.dogNames.map((d) => (
                            <li>{d}</li>
                        ))}
                    </ol>
                </div>
            );
        }
        else {
            return (
                <div>
                    <h1>Hello, {robsDogs.ownerName}!</h1>
                    <h5>You don't have any dogs</h5>
                </div>
            );
        }
    }
}
